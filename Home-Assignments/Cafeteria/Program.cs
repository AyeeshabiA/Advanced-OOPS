using System;
namespace Cafeteria
{
    class Program
    {
        public static void Main(string[] args)
        {
            Operation operate = new Operation();
            operate.Default();
            operate.MainMenu();
        }
    }
}