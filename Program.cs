using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Kiemtra
    {
        static int chon, n, i, j, tmp;
        static void Main(string[] args)
        {
            Console.WriteLine("\nSap xep mang theo thu tu tang dan trong C#:");
            Console.WriteLine("--------------------------------------------");
            Console.Write("Nhap kich co mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[n];
            Console.WriteLine("Nhap {0} phan tu vao trong mang: ", n);


            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
                if (arr1[i] <= 5 || arr1[i] >= 10)
                {
                    Console.Write("moi ban nhap lai: ");
                    arr1[i] = Convert.ToInt32(Console.ReadLine());
                }

            }
            Console.WriteLine("+-----+-----+-----+-----+-----+");
            for (i = 0; i < n; i++)
            {

                Console.Write("{0}  ", arr1[i]);


            }
            Console.WriteLine();
            Console.WriteLine("+-----+-----+-----+-----+-----+");
            ////int x = 0, y = 0;
            ////int x_old, y_old;
            //Console.SetCursorPosition(x, y);//toa do
            //Console.WriteLine("1.   NHap lai day so");
            //Console.WriteLine("2.   In day so");
            //Console.WriteLine("3.   Thoat");
            //banphim = Console.ReadKey();


            //do
            //{
            //    x_old = x; y_old = y;

            //    banphim = Console.ReadKey();
            //    switch (banphim.Key)
            //    {
            //        case ConsoleKey.UpArrow: y--; break;
            //        case ConsoleKey.DownArrow: y++; break;
            //    }


            //    Console.ForegroundColor = ConsoleColor.Black;
            //    Console.SetCursorPosition(x_old, y_old);
            //    Console.WriteLine("1.   NHap lai day so");
            //    Console.ForegroundColor = ConsoleColor.Red;//doi mau chu
            //    Console.SetCursorPosition(x, y);
            //    Console.WriteLine("1.   NHap lai day so");
            //   //Console.SetCursorPosition(x_old, y_old);
            //   // Console.WriteLine("2.   In day so");
            //   // Console.ForegroundColor = ConsoleColor.Red;//doi mau chu
            //   // Console.SetCursorPosition(x, y);
            //   // Console.WriteLine("2.   In day so");
            //   // Console.SetCursorPosition(x_old, y_old);
            //   // Console.WriteLine("3.   Thoat");
            //   // Console.ForegroundColor = ConsoleColor.Red;//doi mau chu
            //   // Console.SetCursorPosition(x, y);
            //   // Console.WriteLine("3.   Thoat");
            //} while (true);

            //switch (chon)
            //{

            //    case 1:
            //        for (i = 0; i < n; i++)
            //        {
            //            tam= (tam + arr1[i]);

            //        }
            //        tb = tam / n;
            //        Console.WriteLine();
            //        Console.WriteLine("{0}.2",tb);
            //        break;
            //    case 2:
            //        break;
            //}

            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[j] < arr1[i])
                    {
                        tmp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = tmp;
                        Thread.Sleep(1000);
                        Console.WriteLine("+-----+-----+-----+-----+-----+");
                        for (int a = 0; a < n; a++)
                        {
                            Console.Write("{0}  ", arr1[a]);
                        }
                        Console.WriteLine();
                        Console.WriteLine("+-----+-----+-----+-----+-----+");

                    }
                    }
            }
            

            
            Console.ReadKey();
          }
            }

        
       
}


