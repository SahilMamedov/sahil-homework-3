using System;

namespace task

{
    class Program
    {
        static void Main(string[] args)
        {
            #region method
            //int result = sum(7, 7);
            // Console.WriteLine(result);

            // string Info = info("Sahil", "Mamedov", 24);
            //Console.WriteLine(Info);

            //Print();

            //Console.WriteLine(Divide(10,6));

            //int[] array={ 1,2,3,4};
            //int result = SumMassiveElement(1,2,3,4,5);
            // Console.WriteLine(result);

            // Console.WriteLine(Subtract(15,7));


            #endregion
            
            Console.WriteLine(sum());
        }

        #region method
        /// <summary>
        /// ededleri toplayir
        /// </summary>
        /// <param name="num1">int num1 qebul edir</param>
        /// <param name="num2">int num2 qebul edir</param>
        /// <returns></returns>
        //static int sum(int num1, int num2)
        //{
        //    return num1 + num2;
        //}
        //static string info(string name, string surname, int age)
        //{
        //    return $"{name} {surname} {age}";
        //}
        //static void Print()
        //{
        //    Console.WriteLine("Her shey yaxshi olacag :)");
        //}

        // static int Divide(int num1, int num2)
        //{
        //    if (num1 > num2)
        //    {
        //        return num1;
        //    }
        //    else
        //    {
        //        return num2;
        //    }

        //}
        //static void Multiple(int num)
        //{
        //    if (num > 5)
        //    {
        //        Console.WriteLine($"{num}");
        //        return;
        //    }
        //    Console.WriteLine("test");

        //}

        // static int SumMassiveElement(int num, params int[] arr)
        // {
        //      int sum = 0;
        //      foreach (var item in arr)
        //      {
        //          sum += item;

        //      }
        //      return sum;
        //  }


        // static int Subtract(int num1, int num2)
        // {
        //     return num1 - num2;
        // }
        #endregion

        // method signature
        //1. methodun adi
        //2. methodun parametrlerinin sayi
        //3. methodun parametrlerinin typi-i

        static int sum(params int[]arry)
        {
            return 4;
        }
        static int sum(int num2)
        {
            return 6;
        }

        static int sum()
        {
            return 7;
        }





    }
}
