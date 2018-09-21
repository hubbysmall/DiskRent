using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IDisk
    {
        List<Disk> getDiskList();
        void addDisk(Disk disk);
        void updateDisk(Disk disk);
        void deleteDisk(Disk disk);
        void returnDisk(Disk disk);
        void giveInRentDisk(Disk disk);


    }
}
