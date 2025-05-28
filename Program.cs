
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini___project___27_5_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.CreateEnemy("aboalik");
            game.CreateWeapon("pistol", "Glock", 10);
            Commando c1 = game.Create_commando(Commando_factory.CommandoType.Air, "John", "Sniper123");
            Console.WriteLine( c1.GetType());
        }
    }
}
