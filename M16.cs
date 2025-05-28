using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini___project___27_5_25
{
    internal class M16:IShootable
    {
        public string Name = "M16";
        public int NumberOfBullets = 29;
        public string Manufacturer = "iwi";
        public void Shoot()
        {
            Console.WriteLine("fg");
        }

    }
}
