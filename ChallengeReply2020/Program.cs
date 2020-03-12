using ChallengeReply2020.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace ChallengeReply2020
{
    class Program
    {
        public static List<Customer> Customers { get; set; }
        public static Header Header { get; set; }
        public static Map Map { get; set; }
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\isaqu\Desktop\5_oceania.txt");

            Customers = new List<Customer>();
            Header = new Header(lines[0]);
            Map = new Map(Header.Width, Header.Height);

            int a = 0;
            int b = 0;

            for (int i = 0; i < Header.Width; i++)
            {
                if (i == 0)
                    continue;

                var line = lines[i];
                for (int j = 0; j < Header.Height; j++)
                {
                    if (i > Header.CustomerNumber)
                    {
                        Map.addLinha(a, b, line[b]);
                        b++;
                    }
                }
                if (i > Header.CustomerNumber)
                {
                    a++;
                    b = 0;
                }
                else
                {
                    Customers.Add(new Customer() { XCoordinate = line[0], YCoordinate = line[1], Prince = line[2] });
                }
            }

            Console.ReadKey();
        }
    }
}
