using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini___project___27_5_25
{
    internal class AirCommando : Commando
    {
        public AirCommando(string name, string code_name) : base(name, code_name)
        {

        }
        public void Fly()
        {
            Console.WriteLine($"{this.code_name} is flying.");
            this.status = "Flying";
        }

        public override void Attack()
        {
            Console.WriteLine($"{this.code_name} is attacking from the air.");
            this.status = "Attacking";
        }
    }
}
