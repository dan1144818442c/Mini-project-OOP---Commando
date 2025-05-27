
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
            Commando commando1 = new Commando("John", "EagleEye");
            commando1.Walk();
            commando1.Hide();
            commando1.Attack();
            commando1.codeName = "yair";
            Console.WriteLine(commando1.codeName );

            Weapon weapon1 = new Weapon("Rifle", "ACME Corp", 30);
            weapon1.Shoot();
            Console.WriteLine(weapon1.GetNumberOfBalls());
            AirCommando airCommando1 = new AirCommando("Sarah", "SkyHawk");
            airCommando1.Attack();
            SeaCommando seaCommando1 = new SeaCommando("Mike", "WaveRider");
            Commando[] arry = { commando1, airCommando1, seaCommando1 };
            foreach(Commando command  in arry)
            {
                command.Attack();

            }
        }
    }
}
