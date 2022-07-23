Skip to content
Search or jump to…
Pull requests
Issues
Marketplace
Explore
 
@tienanh3011 
Nightfury420
/
FinalTesting
Public
Code
Issues
Pull requests
Actions
Projects
Wiki
Security
Insights
FinalTesting/FinalTesting/Program.cs /

May16 Add project files.
Latest commit 52ca279 2 hours ago
 History
 0 contributors
299 lines (278 sloc)  10.4 KB

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FinalTesting
{
    class Program
    {
        private static int x = 0;
        private static int y = 0;
        private static ArrayList m1 = new ArrayList();
        static void Main(string[] args)
        {
            Reprint();

            var readKeys = new Task(ReadKeys);
            readKeys.Start();

            var tasks = new[] { readKeys };

            Task.WaitAll(tasks);

            Console.CancelKeyPress += (sender, e) =>
            {
                Environment.Exit(0);
            };

        }
        private static void MenuOrginal()
        {
            Console.Clear();
            Console.WriteLine("+---------+---------+");
            Console.WriteLine("|        Menu:      |");
            Console.WriteLine("+---------+---------+");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("1.Nhap lai day so");
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("2.Sap xep tang dan");
            Console.WriteLine("3.Sap xep giam dan");
            Console.WriteLine("4.In ket qua");
            Console.WriteLine("5.Demo sx tang dan");
            Console.WriteLine("6.Thoat");
            Console.WriteLine("+---------+---------+");
        }
        private static void Menu()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("+---------+---------+");
            Console.WriteLine("|        Menu:      |");
            Console.WriteLine("+---------+---------+");
            Console.WriteLine("1.Nhap lai day so");
            Console.WriteLine("2.Sap xep tang dan");
            Console.WriteLine("3.Sap xep giam dan");
            Console.WriteLine("4.In ket qua");
            Console.WriteLine("5.Demo sx tang dan");
            Console.WriteLine("6.Thoat");
            Console.WriteLine("+---------+---------+");
        }
        private static int Y = 3;
        private static void ReadKeys()
        {
            int Order;
            ConsoleKeyInfo key = new ConsoleKeyInfo();
            while (!Console.KeyAvailable && key.Key != ConsoleKey.Escape)
            {
                key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (Y != 3)
                        {
                            switch (Y)
                            {
                                case 4:
                                    Menu();
                                    Y--;
                                    UpDown(Y);
                                    break;
                                case 5:
                                    Menu();
                                    Y--;
                                    UpDown(Y);
                                    break;
                                case 6:
                                    Menu();
                                    Y--;
                                    UpDown(Y);
                                    break;
                                case 7:
                                    Menu();
                                    Y--;
                                    UpDown(Y);
                                    break;
                                case 8:
                                    Menu();
                                    Y--;
                                    UpDown(Y);
                                    break;
                            }
                        }
                        break;

                    case ConsoleKey.DownArrow:
                        if (Y != 8)
                        {
                            switch (Y)
                            {
                                case 3:
                                    Menu();
                                    Y++;
                                    UpDown(Y);
                                    break;
                                case 4:
                                    Menu();
                                    Y++;
                                    UpDown(Y);
                                    break;
                                case 5:
                                    Menu();
                                    Y++;
                                    UpDown(Y);
                                    break;
                                case 6:
                                    Menu();
                                    Y++;
                                    UpDown(Y);
                                    break;
                                case 7:
                                    Menu();
                                    Y++;
                                    UpDown(Y);
                                    break;
                            }
                        }
                        break;

                    case ConsoleKey.Enter:
                        switch (Y)
                        {
                            case 3:
                                Reprint();
                                break;
                            case 4:
                                Order = 0;
                                Sort(Order);
                                Console.SetCursorPosition(x + 25, Y);
                                Console.Write("SORT COMPLETED! hit enter to delete");
                                Console.ReadLine();
                                Console.SetCursorPosition(x + 25, Y);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("SORT COMPLETED! hit enter to delete");
                                Console.ForegroundColor = ConsoleColor.Black;
                                break;
                            case 5:
                                Order = 1;
                                Sort(Order);
                                Console.SetCursorPosition(x + 25, Y);
                                Console.Write("SORT COMPLETED! hit enter to delete");
                                Console.ReadLine();
                                Console.SetCursorPosition(x + 25, Y);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("SORT COMPLETED! hit enter to delete");
                                Console.ForegroundColor = ConsoleColor.Black;
                                break;
                            case 6:
                                Print();
                                break;
                            case 7:

                                break;
                            case 8:
                                Environment.Exit(0);
                                break;
                        }
                        break;
                }
            }
        }

        private static void UpDown(int Y)
        {
            Console.SetCursorPosition(x, Y);
            Console.BackgroundColor = ConsoleColor.Red;
            switch(Y)
            {
                case 3:
                    Console.WriteLine("1.Nhap lai day so");
                    break;
                case 4:
                    Console.WriteLine("2.Sap xep tang dan");
                    break;
                case 5:
                    Console.WriteLine("3.Sap xep giam dan");
                    break;
                case 6:
                    Console.WriteLine("4.In ket qua");
                    break;
                case 7:
                    Console.WriteLine("5.Demo sx tang dan");
                    break;
                case 8:
                    Console.WriteLine("6.Thoat");
                    break;
            }
            Console.BackgroundColor = ConsoleColor.White;
        }

        private static void Reprint()
        {
            Console.CursorVisible = true;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            int n = 7;
            m1.Clear();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap vao so {0} cua day so cua ban: ", i);
                int t = int.Parse(Console.ReadLine());
                m1.Add(t);
            }

            for (int i = 3; i >= 0; i--)
            {
                Console.SetCursorPosition(x, y + (n));
                Console.WriteLine("Screen will clear in {0}", i);
                Thread.Sleep(1000);
            }
            Console.CursorVisible = false;

            MenuOrginal();
        }

        private static int[] sorted = new int[12];
        private static void Sort(int Order)
        {
            Array.Clear(sorted, 0, sorted.Length);

            for (int i = 0; i < m1.Count; i++)
            {
                sorted[i] = Convert.ToInt32(m1[i]);
            }
            if (Order == 0)
            {
                for (int i = 0; i < m1.Count; i++)
                {
                    for (int j = i; j < m1.Count; j++)
                    {
                        if (sorted[i] > sorted[j])
                        {
                            int tmp = sorted[i];

                            sorted[i] = sorted[j];

                            sorted[j] = tmp;
                        }
                    }
                }
            }
            else if (Order == 1)
            {
                for (int i = 0; i < m1.Count; i++)
                {
                    for (int j = i; j < m1.Count; j++)
                    {
                        if (sorted[i] < sorted[j])
                        {
                            int tmp = sorted[i];

                            sorted[i] = sorted[j];

                            sorted[j] = tmp;
                        }
                    }
                }
            }  
        }
        private static void Print()
        {
            int plus = 0;
            for (int i = 0; i < m1.Count; i++)
            {
                Console.SetCursorPosition(x + 20 + plus +i, Y);
                Console.WriteLine("+----+");
                Console.SetCursorPosition(x + 20 + plus + i, Y + 1);
                Console.WriteLine(sorted[i] + " | ");
                Console.SetCursorPosition(x + 20 + plus + i, Y + 2);
                Console.WriteLine("+----+");
                plus 
            }
        }
    }
}
Footer
© 2022 GitHub, Inc.
Footer navigation
Terms
Privacy
Security
Status
Docs
Contact GitHub
Pricing
API
Training
Blog
About
You have no unread notifications
