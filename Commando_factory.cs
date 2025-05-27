using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini___project___27_5_25
{
    internal class Commando_factory
    {
        protected List<Commando> commandos = new List<Commando>();
        public Commando Create_commando(string type, string name, string code_name)
        {
            if (type == "Air")
            {
                AirCommando comando =  new AirCommando(name, code_name);
                commandos.Add(comando);
                return comando;
            }
            else if (type == "Sea")
            {
                SeaCommando commando =  new SeaCommando(name, code_name);
                commandos.Add(commando);
                return commando;
            }
            else
            {
                throw new ArgumentException("Invalid commando type");
            }
        }
    }
}
