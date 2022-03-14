using System;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) Bir method olsun iki parametr qəbul etsin və bu parametrlərdən birincini ikinciyə bölüb nəticəni geri qaytarsın.

            Console.WriteLine("Bolmek istediyiniz ededi daxil edin");
            double bolunen = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Boleceyiniz ededi daxil edin");
            double bolen = Convert.ToDouble(Console.ReadLine());

           double result = kalkulate(bolunen,bolen);
            Console.WriteLine($"Netice---{result}");

        }
        static double kalkulate(double bolunen, double bolen)

        {
            return bolunen / bolen;
        }
    }
}
