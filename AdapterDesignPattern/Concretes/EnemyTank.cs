using AdapterDesignPattern.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.Concretes
{
    public class EnemyTank : EnemyAttacker
    {
        Random random = new Random();
        public void fireWeapon()
        {
            int attackDamage = random.Next(10) + 1;
            Console.WriteLine("Enemy Tank Does " + attackDamage + " Damage");
        }

        public void driveForward()
        {
            int movement = random.Next(5) + 1;
            Console.WriteLine("Enemy Tank moves " + movement + " spaces");
        }

        public void assignDriver(string driverName)
        {
            Console.WriteLine(driverName + " is driving the tank");
        }

    }
}
