using System;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 4)               Sahe deyə Method(lar) yaradılır.
                                Çevrənin sahəsi - S = p*r² (p=3)
                                Düzbucaqlının sahəsi - S = a*b
                                Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi - S=p*r; p=(a+b+c)/2    */


            double perimetr, radius;
            Console.WriteLine("Zehmet olmasa sahenin radiusun daxil edin");
            radius = Convert.ToDouble(Console.ReadLine());
            perimetr = 3;
            sahe(perimetr, radius);

            
            double DuzbucaqlininEni, DuzbucaqlininUzunluqu,s=0;
            Console.WriteLine("Duzbucaqlinin Enin daxil edin");
            DuzbucaqlininEni = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Duzbucaqlinin Uzunluqun daxil edin");
            DuzbucaqlininUzunluqu = Convert.ToDouble(Console.ReadLine());
            sahe(DuzbucaqlininEni, DuzbucaqlininUzunluqu, s);



            double radiuss, a, b, c;
          
           
            Console.Write("a=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b=");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c=");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Uchbucaqlinin radiusun daxil edin");
            radiuss = Convert.ToDouble(Console.ReadLine());

            sahe (radiuss, a, b, c, s);

        }

        static void sahe(double p, double r)
        {

            r = r * r;
            double s = p * r;
            Console.WriteLine($"Cevrenin sahesi--{s}");

        }

        static void sahe(double DuzbucaqlininEni, double DuzbucaqlininUzunluqu, double s)
        {
            

           

            s = DuzbucaqlininEni * DuzbucaqlininUzunluqu;
        
            Console.WriteLine($"Duzbucaqlinin sahesi--{s}");
        }
        static void sahe( double radiuss, double a,double b,double c,double s)
        {
           
           
           double  perimetrr = (a + b + c) / 2;
                   s = perimetrr * radiuss;

            Console.WriteLine($"Uchbucaqlinin daxiline chekilmish cevrenin sahesi----{s}");
        }
    }
}
