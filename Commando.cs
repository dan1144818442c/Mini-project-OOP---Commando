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
        public string status { get; set; }
        public string codeName { get; set; }

        protected Commando(string name, string code_name)
        {
            this.name = name;
            this.code_name = code_name;
            this.status = null;

        }

        public static Commando CreateCommando(string name, string code_name)
        {
            return new Commando(name, code_name);
        }
        public string GetName(string commanderRank)
        {
            if (commanderRank == "GENERAL")
            {
                return this.name;
            }
            else
            {
                if (commanderRank == "COLONEL")
                {
                    return this.code_name;
                }
            }
            Console.WriteLine("Your rank is not high enough to access this classified information.");

            return null;
        }

        

        public string[] GetTools()
        {
            return this.tools;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
    
    
        public void Walk()
        {
            Console.WriteLine($"{this.code_name} is walking.");
            this.status = "Walking";
        }
        public void Hide()
        {
            Console.WriteLine($"{this.code_name} is hiding.");
            this.status = "Hiding";
        }

        public virtual void Attack()
        {
            Console.WriteLine($"{this.code_name} is attacking.");
            this.status = "Attacking";
        }
    }
}
