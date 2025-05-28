using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini___project___27_5_25
{
    internal class Game
    {
        Commando_factory factory;
        Weapond_factorty weaponFactory;
        EnemyFactoty enemyFactory;
       
        public Game()
        {
            factory = new Commando_factory();
            weaponFactory = new Weapond_factorty();
            enemyFactory = new EnemyFactoty();
        }

        public Commando Create_commando(Commando_factory.CommandoType type, string name, string code_name)
        {
            return factory.Create_commando(type, name, code_name);
        }
        public Weapon CreateWeapon(string type, string name, int num_of_ball)
        {
            return weaponFactory.CreateWeapon(type, name, num_of_ball);
        }
        public Enemy CreateEnemy(string name)
        {
            return enemyFactory.createEnemy( name);
        }



    }
}
