using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // ## Can not create object due constructor is priavte
            //Logger logObj1 = new Logger();        

            // ## Get single object without creating main objects
            //Logger logObj1 = Logger.GetInstance();
            //Logger logObj2 = Logger.GetInstance();

            // ## Get single object using getters
            Logger logObj1 = Logger.Instance;
            Logger logObj2 = Logger.Instance;

            // logObj1 && logObj2 both object are same. Please check hashcode
            Console.WriteLine("Logger Object 1 " + logObj1.GetHashCode());
            Console.WriteLine("Logger Object 2 " + logObj2.GetHashCode());
            Console.ReadLine();
        }
    }
}
