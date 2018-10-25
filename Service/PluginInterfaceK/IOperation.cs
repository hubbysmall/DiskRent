using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.PluginInterfaceK
{
    public interface IOperation
    {
        string Operation { get; }

        bool operate(DbSet<Disk> entities);
    }
}
