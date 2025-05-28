using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini___project___27_5_25
{
    internal class Commando_factory
    {
        public enum CommandoType
        {
            Regular,
            Air,
            Sea
        }

        protected List<Commando> commandos = new List<Commando>();
        public Commando Create_commando(CommandoType type, string name, string code_name)
        {
            Commando commando;
            switch (type)
            {
                case CommandoType.Regular:
                    commando = Commando.CreateCommando(name, code_name);
                    commandos.Add(commando);
                    return commando;
                case CommandoType.Air:
                    commando = new AirCommando(name, code_name);
                    commandos.Add(commando);
                    return commando;
                case CommandoType.Sea:
                    commando = new SeaCommando(name, code_name);
                    commandos.Add(commando);
                    return commando;

                default:
                    Console.WriteLine("Invalid commando type.");
                    return null;

            }

        }
    }
}
