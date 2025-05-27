using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini___project___27_5_25
{
    internal class Commando
    {
        protected string name;
        protected string code_name;
        protected string[] tools = { "Hammer", "chisel", "rope", "bag", "water bottle" };
        protected string status;

        public Commando(string name, string code_name , string status)
        {
            this.name = name;
            this.code_name = code_name;
            this.status = status;

        }

        public void Walk()
        {
            Console.WriteLine($"{this.name} is walking.");
            this.status = "Walking";
        }
        public void Hide()
        {
            Console.WriteLine($"{this.name} is hiding.");
            this.status = "Hiding";
        }

        public void Attack()
        {
            Console.WriteLine($"{this.name} is attacking.");
            this.status = "Attacking";
        }
    }
}
