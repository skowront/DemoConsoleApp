using System.Runtime.CompilerServices;

namespace DemoConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = true;
            while (true)
            {
                Program.Work(x);
                x = !x;
            }
        }

        public static void Work(bool x)
        {
            Console.WriteLine("Working: "+x.ToString());
        }
    }
}