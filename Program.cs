using System;

namespace Test
{
    class Kiemtra
    {
        static int chon, n, i, j, tmp;
        static float tam, tb;
       
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
                      if (arr1[i] <=5 || arr1[i] >= 10)
                        {
                      Console.Write("moi ban nhap lai: ");
                      arr1[i] = Convert.ToInt32(Console.ReadLine());
                        }
                          
                }
            
            Console.WriteLine("1.   Sort");
            Console.WriteLine("2.   Show");
            Console.WriteLine("3.   EXIT");
            chon = Convert.ToInt32(Console.ReadLine());
            
            switch (chon)
            {
                case 1:
                    
                    for (i = 0; i < n; i++)
                    {
                        for (j = i + 1; j < n; j++)
                        {
                            if (arr1[j] < arr1[i])
                            {

                                tmp = arr1[i];
                                arr1[i] = arr1[j];
                                arr1[j] = tmp;
                            }
                        }
                    }
                    Console.Write("In cac phan tu mang theo thu tu tang dan:\n");
                    for (i = 0; i < n; i++)
                    {
                        Console.Write("{0}  ", arr1[i]);
                    }
                    Console.WriteLine();
                    Console.ReadKey();
                    goto case 2;
                case 2:
                    for (i = 0; i < n; i++)
                    {
                        tam= (tam + arr1[i]);

                    }
                    tb = tam / n;
                    Console.WriteLine();
                    Console.WriteLine("{0}.2",tb);
                    break;
                case 3:
                    break;
            }
            
        }
       }
}


