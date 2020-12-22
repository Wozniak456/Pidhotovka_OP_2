using System;

namespace Pidhotovka_OP_2
{
    class Program
    {
        static double Calc(int x,int y,char op)
        {
            int rez = 0;
            if (op == '+')
            {
                rez = x + y;
            }
            else if (op == '-')
            {
                rez = x - y;
            }
            else if (op == '*')
            {
                rez = x * y;
            }
            else if (op == '/')
            {
                rez = x / y;
            }
            return rez;
        }
        static void Main(string[] args)
        {
            int value1 = 1; int value2 = 1;
            while (value1 !=0 && value2 != 0)
            {
                Console.Write("Input value1: ");
                value1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input value2: ");
                value2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input operation: ");
                char op = Convert.ToChar(Console.ReadLine());
                Console.WriteLine(Calc(value1, value2, op));
            }
            
        }
    }
}
