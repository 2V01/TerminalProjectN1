using System;
using System.Collections.Generic;
using System.Text;

namespace TerminalApp
{
    public class Terminal
    {
        public void start()
        {
            bool exit = true;
            while (exit)
            {
                string userComand, way = @"user\";

                Console.Write("[User]: ");
                userComand = Console.ReadLine();

                switch (userComand)
                {
                    case "ShowTheWay":
                        Console.WriteLine($"[Console]: {way}");
                        Console.WriteLine();
                        break;

                    case "Eneble":
                        Console.WriteLine("[Console]: Access is allowed");
                        Console.WriteLine();
                        adminCat();
                        break;

                    case "Help":
                        Console.WriteLine("[Console]: ShowTheWay Eneble Help Exit");
                        Console.WriteLine();
                        break;

                    case "Exit":
                        exit = false;
                        break;

                    default:
                        Console.WriteLine("[Console]: Введена неверная команда! Напишите Help, что бы узнать список команд.");
                        Console.WriteLine();
                        break;
                }
            }
            Console.ReadKey();
        }

        private void adminCat()
        {
            string userComand, way = @"user\admin\";

            bool exit = true;

            while (exit)
            {
                Console.Write("[Admin]: ");
                userComand = Console.ReadLine();

                switch (userComand)
                {
                    case "ShowTheWay":
                        Console.WriteLine($"[Console]: {way}");
                        Console.WriteLine();
                        break;

                    case "Disable":
                        Console.WriteLine();
                        exit = false;
                        break;

                    case "Help":
                        Console.WriteLine("[Console]: ShowTheWay ExtraEneble Disable Help");
                        Console.WriteLine();
                        break;

                    case "ExtraEneble":
                        Console.WriteLine("[Console]: Access is allowed");
                        Console.WriteLine();
                        extraAdminCat();
                        break;

                    default:
                        Console.WriteLine("[Console]: Введена неверная команда! Напишите Help, что бы узнать список команд.");
                        Console.WriteLine();
                        break;
                }
            }
        }

        private void extraAdminCat()
        {
            string userComand, way = @"user\admin\extra\";

            bool exit = true;

            while (exit)
            {
                Console.Write("[Extra]: ");
                userComand = Console.ReadLine();

                switch (userComand)
                {
                    case "ShowTheWay":
                        Console.WriteLine($"[Console]: {way}");
                        Console.WriteLine();
                        break;

                    case "ExtraDisable":
                        Console.WriteLine();
                        exit = false;
                        break;

                    case "Help":
                        Console.WriteLine("[Console]: ShowTheWay ExtraDisable Help");
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("[Console]: Введена неверная команда! Напишите Help, что бы узнать список команд.");
                        Console.WriteLine();
                        break;
                }
            }
        }

    }
}
