using System;

namespace practiceCode
{
    class Program
    {
        
        public static string title = "c# essebtial training";
        public static int whichPart;
        static void Main(String[] args)
        {
            whichPart=2;
            var message = string.Format("Welcome to {0} : part 1", title, whichPart);
            Console.WriteLine(message);
            Console.WriteLine("press enter to exit");
            Console.ReadLine(); 
    }
    }
}
