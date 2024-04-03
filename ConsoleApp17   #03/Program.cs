using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17____03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ededi daxil edin");
            int num = Convert.ToInt32(Console.ReadLine());

            int ters=Method(num);





           


            int reqemsay = 0;
            int temp = ters;

            while (temp > 0)
            {
                reqemsay++;
                temp /= 10;
            }




            int[] arr = new int[reqemsay];
            int index = 0;
            while (ters > 0)
            {
                int t = ters % 10;
                arr[reqemsay-index-1] = t;
                ters /= 10;
                index++;
            }

            foreach (var item in arr)
            {
                Console.Write(item);
            }

        }

        static int Method(int num)
        {
           
            int num1;
            if (num > 999)
            {
                Console.Write("Ededin tersi : ");
                while (num > 10)
                {
                    num1 = num % 10;
                    Console.Write(num1);
                    num /= 10;
                }
                
            }
            return num;
        }
    }
}
