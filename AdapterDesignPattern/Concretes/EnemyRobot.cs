using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.Concretes
{
    public class EnemyRobot
    {
        Random random = new Random();
        public void smashWithHands()
        {
            int attackDamage = random.Next(20) + 1;
            Console.WriteLine("Enemy Robot Causes"+attackDamage+"Damage With Its Hands");
        }
        public void walkForward()
        {
            int movement = random.Next(20) + 1;
            Console.WriteLine("Enemy Robot Walks Forward"+movement+"spaces");
        }
        public void reactToHuman(string driveName) 
        {
            Console.WriteLine("Enemy Robot Tramps On"+driveName);
        }
    }
}
