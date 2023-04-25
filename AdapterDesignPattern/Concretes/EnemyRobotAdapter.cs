using AdapterDesignPattern.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.Concretes
{
    public class EnemyRobotAdapter : EnemyAttacker
    {
        EnemyRobot theRobot;
        public EnemyRobotAdapter(EnemyRobot newRobot)
        {
            theRobot = newRobot;
        }
        public void assignDriver(string driverName)
        {
            theRobot.reactToHuman(driverName);
        }

        public void driveForward()
        {
            theRobot.walkForward();
        }

        public void fireWeapon()
        {
            theRobot.smashWithHands();
        }
    }
}
