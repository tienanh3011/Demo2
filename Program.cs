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
        static int a = 0;
        static int b = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("1.Nhap day so");
            Console.WriteLine("2.Sap xep tang dan");
            Console.WriteLine("3.Sap xep giam dan");
            Console.WriteLine("4.In ket qua");
            Console.WriteLine("5.Demo sx tang dan");
            Console.WriteLine("6.Thoat");
           chon = Convert.ToInt32(Console.ReadLine());
            n = 3;
            int[] arr1 = new int[n];
            switch (chon)
            {
                case 1:
                    
                    Console.WriteLine("Nhap {0} phan tu vao trong mang: ", n);
                    for (i = 0; i < n; i++)
                    {
                        Console.Write("Phan tu - {0}: ", i);
                        arr1[i] = Convert.ToInt32(Console.ReadLine());

                    }
                    goto case 2;

                    Console.WriteLine("+-----+-----+-----+-----+-----+----+");
                    for (i = 0; i < n; i++)
                    {

                        Console.Write("| {0}  ", arr1[i]);


                    }
                    Console.WriteLine();
                    Console.WriteLine("+-----+-----+-----+-----+-----+----+");
                case 2:
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
                                Console.Clear();
                                Console.WriteLine("+-----+-----+-----+-----+-----+----+");
                                for ( a = 0; a < n; a++)
                                {
                                    Console.Write("| {0}  ", arr1[a]);
                                }
                                Console.WriteLine();
                                Console.WriteLine("+-----+-----+-----+-----+-----+----+");

                            }
                        }
                    }
                    goto case 3;
                case 3:
                     for (i = 0; i < n; i++)
                     {
                        for (j = i + 1; j < n; j++)
                        {
                            if (arr1[j] > arr1[i])
                            {
                                tmp = arr1[i];
                                arr1[i] = arr1[j];
                                arr1[j] = tmp;
                                Thread.Sleep(1000);
                                Console.Clear();
                                Console.WriteLine("+-----+-----+-----+-----+-----+----+");
                                for (b = 0; b < n; b++)
                                {
                                    Console.Write("| {0}  ", arr1[b]);
                                }
                                Console.WriteLine();
                                Console.WriteLine("+-----+-----+-----+-----+-----+----+");

                            }
                        }
                    }goto case 4;
                case 4:
                    {
                        Console.WriteLine("+-----+-----+-----+-----+-----+----+");
                        for ( a = 0; a < n; a++)
                        {
                            Console.Write("| {0}  ", arr1[a]);
                        }
                        Console.WriteLine();
                        Console.WriteLine("+-----+-----+-----+-----+-----+----+");
                        Console.WriteLine("+-----+-----+-----+-----+-----+----+");
                        for (b = 0; b < n; b++)
                        {
                            Console.Write("| {0}  ", arr1[b]);
                        }
                        Console.WriteLine();
                        Console.WriteLine("+-----+-----+-----+-----+-----+----+");
                        
                    }

                    goto case 5; 
                    case 5:
                    {
                        Console.WriteLine("+-----+-----+-----+-----+-----+----+");
                        for (i = 0; i < n; i++)
                        {

                            Console.Write("| {0}  ", arr1[i]);


                        }
                        Console.WriteLine();
                        Console.WriteLine("+-----+-----+-----+-----+-----+----+");
                    }goto case 6; 
                case 6:
                    break;

            }
            Console.ReadKey();
        }
    }



}

