using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini___project___27_5_25
{
    internal class SeaCommando:Commando
    {
        public SeaCommando(string name, string code_name) : base(name, code_name)
        {
        }
        public void Swim()
        {
            Console.WriteLine($"{this.code_name} is swimming.");
            this.status = "Swimming";
        }
        public override void Attack()
        {
            Console.WriteLine($"{this.code_name} is attacking from the sea.");
            this.status = "Attacking";
        }
    }
}
