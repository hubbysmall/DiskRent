using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Service
{
    public class DiskService : IDisk
    {
        private RentDbContext context;

        public DiskService(RentDbContext context)
        {
            this.context = context;
        }

        public void addDisk(Disk disk)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    Disk element = context.Disks.FirstOrDefault(rec => rec.name == disk.name);
                    if (element != null)
                    {
                        throw new Exception("Уже есть изделие с таким названием");
                    }
                    element = new Disk
                    {
                        name = disk.name,
                        genre = disk.genre,
                        description = disk.description,
                        country = disk.country,
                        director = disk.director
                    };
                    context.Disks.Add(element);
                    context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

         public void deleteDisk(Disk disk)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    Disk element = context.Disks.FirstOrDefault(rec => rec.Id == disk.Id);
                    context.Disks.Remove(element);
                    context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public List<Disk> getDiskList()
        {            
            return context.Disks.ToList();
        }

        public void  giveInRentDisk(Disk disk)
        {

            Disk element = context.Disks.FirstOrDefault(rec => rec.Id == disk.Id);
            if (element == null)
            {
                throw new Exception("Фильм не найден");
            }
    
            element.takenByClient = true;
            context.SaveChanges();
        }

        public void returnDisk(Disk disk)
        {
            Disk element = context.Disks.FirstOrDefault(rec => rec.Id == disk.Id);
            if (element == null)
            {
                throw new Exception("Фильм не найден");
            }

            element.takenByClient = false;
            context.SaveChanges();
        }

        public void updateDisk(Disk disk)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    Disk element = context.Disks.FirstOrDefault(rec =>
                                        rec.name == disk.name && rec.director == disk.director && rec.Id != disk.Id);
                    if (element != null)
                    {
                        throw new Exception("Уже есть фильм с такими характеристиками");
                    }
                    element = context.Disks.FirstOrDefault(rec => rec.Id == disk.Id);
                    if (element == null)
                    {
                        throw new Exception("Фильм не найден");
                    }
                    element.name = disk.name;
                    element.genre = disk.genre;
                    element.description = disk.description;
                    element.country = disk.country;
                    element.director = disk.director;
                    context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}
