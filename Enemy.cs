using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini___project___27_5_25
{
    internal class Enemy
    {
        string name;
        int life;
        string status;
        private Enemy(string name)
        {
            this.name = name;
            this.life = 100;
            this.status = "Alive";
        }
        public void shout()
        {
            Console.WriteLine($"{this.name} is Enemy!");


        }
        internal static Enemy creat_enemy(string name)
        {
            return new Enemy(name);
        }
            
    }
}