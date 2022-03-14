using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Repeat deyə bir method olsun və iki parametr qəbul etsin biri "word" digəri "count" 
               yəni bu şəkildə "Repeat(string word, int count)"
               bu method göndərilən word-ü göndərilən count qədər yan-yana yazdırıb geri qaytarsın.Məsələn: */

            string word = Convert.ToString(Console.ReadLine());
            int count = Convert.ToInt32(Console.ReadLine());
            repeat(word, count) ;
           
        }

        static string repeat(string word,int count)
        {

            for (int i = 1; i <= count; i++)
            {

                Console.Write(word);

            }
            return word;


        }






    }
}
