using System;
namespace SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singletonInstance1 =  Singleton.getInstance();
            Singleton singletonInstance2 =  Singleton.getInstance();

            if (singletonInstance1==singletonInstance2)
            {
                Console.WriteLine("singletonInstance1 and singletonInstance2 are same object");
            }
            else
            {
                Console.WriteLine("singletonInstance1 and singletonInstance2 are different objects");
            }

        }
       
    }
    public class Singleton
    {
        private Singleton()
        {

        }
        private static Singleton firstInstance = null;

        public static Singleton getInstance()
        {
            if (firstInstance == null)
            {
                firstInstance = new Singleton();
            }

            return firstInstance;
        }

        public void ShowMessage()
        {
            Console.WriteLine("Created Singleton Object");
        }
    }
}
