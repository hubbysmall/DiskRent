using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using ImportManyAttribute = System.ComponentModel.Composition.ImportManyAttribute;

namespace OurPlugIns
{
    public class Manager
    {
        [ImportMany(typeof(IOperation))]
        IEnumerable<IOperation>Plugins { get; set; }

        public readonly Dictionary<string, Func<DbSet<Disk>, bool>> Operations =
            new Dictionary<string, Func<DbSet<Disk>, bool>>();

        public string[] Headers { get; private set; }

        public Manager()
        {
            AggregateCatalog catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new DirectoryCatalog(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plugins")));

            CompositionContainer container = new CompositionContainer(catalog);
            container.ComposeParts(this);
            if(Plugins.Count() != 0)
            {
                Plugins.ToList().ForEach(p => Operations.Add(p.Operation, (entities) => p.operate(entities)));
                Headers = Operations.Keys.ToArray();
            }

        }

    }
}
