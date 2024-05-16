using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Zachary_Renyhart_Week_2_Challenge_Labs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello please enter your degrees");
            int outPut = Convert.ToInt32(Console.ReadLine());

            switch (outPut)
            {
                case int when outPut >= 0 && outPut <= 10: //This is what you need to add for a int to be added to a case.
                    Console.WriteLine("It is freezing weather!");
                    break;

                case int when outPut >= 11 && outPut <= 20:
                    Console.WriteLine("It is very cold weather!");
                    break;

                case int when outPut >= 21 && outPut <= 35:
                    Console.WriteLine("It is cold weather!");
                    break;

                case int when outPut >= 36 && outPut <= 50:
                    Console.WriteLine("It is normal weather!");
                    break;

                case int when outPut >= 51 && outPut <= 65:
                    Console.WriteLine("It is hot weather!");
                    break;

                case int when outPut >= 66 && outPut <= 80:
                    Console.WriteLine("It is very hot weather!");
                    break;
            }


        }    
    }

}
