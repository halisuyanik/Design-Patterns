using AdapterDesignPattern.Abstracts;
using AdapterDesignPattern.Concretes;
using System;

namespace AdapterDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            EnemyTank rx7Tank = new EnemyTank();
            EnemyRobot fredTheRobot = new EnemyRobot();
            EnemyAttacker robotAdapter = new EnemyRobotAdapter(fredTheRobot);

            Console.WriteLine("The Robot");

            rx7Tank.assignDriver("Jhon");
            rx7Tank.fireWeapon();
            rx7Tank.driveForward();
            Console.WriteLine("The Enemy Tank");

            fredTheRobot.reactToHuman("Doe");
            fredTheRobot.walkForward();
            fredTheRobot.smashWithHands();
            Console.WriteLine("The Robot with Adapter");

            robotAdapter.assignDriver("Ryan");
            robotAdapter.fireWeapon();
            robotAdapter.driveForward();
        }
    }
}
