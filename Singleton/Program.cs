using System;

namespace Singleton
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Not the same");
            }
        }
    }

    
}
