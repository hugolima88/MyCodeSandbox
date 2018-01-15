using System;

namespace MyCodeTestSandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new WhereExpandMinesweeperClass();

            Console.WriteLine("**** Class: " + program.GetType().Name + " ****");
            Console.WriteLine();

            Console.WriteLine("Result:" + Environment.NewLine);

            program.Run();

            Console.Read();
        }
    }
}
