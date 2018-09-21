using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using Models;

namespace Service
{
    [Table("RentDatabase")]
    public class RentDbContext : DbContext
    {
        public RentDbContext()
        {
            //настройки конфигурации для entity
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public virtual DbSet<Disk> Disks { get; set; }

    }
}
