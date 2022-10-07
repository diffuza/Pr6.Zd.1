
using System;
using System;
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double x,S ;
            Console.WriteLine("Введите значение переменной x: ");
            x = Convert.ToDouble(Console.ReadLine());
            double Pi = 3.1415926535;
            Console.WriteLine("Значение Pi равно: {0}", Pi);
            S = x - Pi;
            Console.WriteLine("Разность x-Pi равна: {0}",Math.Round (S,8));
            Console.ReadLine();
           
        }
    }
}