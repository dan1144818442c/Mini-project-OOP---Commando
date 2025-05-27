
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
            Console.WriteLine(commando1.GetCodeName());
            Console.WriteLine(commando1.GetName());
            Console.WriteLine( commando1.GetStatus());
            Weapon weapon1 = new Weapon("Rifle", "ACME Corp", 30);
            weapon1.Shoot();
            Console.WriteLine(weapon1.GetNumberOfBalls());
        }
    }
}
