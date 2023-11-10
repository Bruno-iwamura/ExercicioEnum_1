using ExercicioEnum.Entities;
using System;

namespace ExercicioEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            HourContract teste = new HourContract(DateTime.Now,20.0,2);

            double result = teste.totalValue();

            Console.WriteLine(result);

            Console.WriteLine(teste);
        }
    }
}