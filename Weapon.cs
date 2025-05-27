using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini___project___27_5_25
{
    internal class Weapon
    {
        string name;
        string Manufacturer;
        int Number_of_balls;
        public Weapon(string name, string manufacturer, int number_of_balls)
        {
            this.name = name;
            this.Manufacturer = manufacturer;
            this.Number_of_balls = number_of_balls;
        }

        public void Shoot()
        {
            if (this.Number_of_balls <= 0)
            {
                Console.WriteLine("no balls from this weapon");
                return;
            }

             Console.WriteLine($"{this.name} is shooting.");
            this.Number_of_balls--;
        }
        public void GetName()
        {
            Console.WriteLine($"Weapon Name: {this.name}");
        }
        public string GetManufacturer()
        {
            return this.Manufacturer;
        }
        public int GetNumberOfBalls()
        {
            return this.Number_of_balls;
        }

    }
}
