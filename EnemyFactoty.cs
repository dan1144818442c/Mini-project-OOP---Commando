using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini___project___27_5_25
{

    internal class EnemyFactoty
    {
        private List<Enemy> enemies = new List<Enemy>();

        public Enemy createEnemy(string name)
        {
            Enemy enemy = Enemy.creat_enemy(name);
            enemies.Add(enemy);
            return enemy;
        }
        public List<Enemy> getEnemies()
        {
            return enemies;
        }

    }
}
