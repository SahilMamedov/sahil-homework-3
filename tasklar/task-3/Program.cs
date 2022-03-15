using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3) Bir method olsun göndərilən "n" sayda ədədin hamsını toplayıb geri qaytarsın.

            // commentde olan kodlar 2-ci usula aitdir 

            //Console.WriteLine("Nece eded toplanshin ?");
            //int array = Convert.ToInt32(Console.ReadLine());

            //int[] eded = new int[array];

            //toplama(eded);

            toplama(6, 7, 8);

            Console.WriteLine(toplama(6, 7, 8));
        }
        static int toplama(params int[] eded)
        {
            int result = 0;
            for (int i = 0; i < eded.Length; i++)
            {

                result += eded[i];

            }
            Console.WriteLine(result);
            return result;


            //static int toplama(int[] eded)
            //{

            //    int result = 0;
            //    for (int i = 0; i < eded.Length; i++)
            //    {
            //        Console.Write((i + 1).ToString() + ".Ededi daxil edin: ");
            //        eded[i] = Convert.ToInt32(Console.ReadLine());
            //        result += eded[i];

            //    }
            //    Console.WriteLine($"sum-----{result}");
            //    return result;


            //}


        }
    }
}
