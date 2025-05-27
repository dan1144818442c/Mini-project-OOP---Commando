using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini___project___27_5_25
{
    internal class Weapond_factorty
    {
        protected List<Weapon> weapons = new List<Weapon>();
        public Weapon CreateWeapon(string type, string name, int num_of_ball)
        {
            
                Weapon rifle = Weapon.create_weapon(name, type, num_of_ball);
            weapons.Add(rifle);
                return rifle;
            
            
        }
    }
}
