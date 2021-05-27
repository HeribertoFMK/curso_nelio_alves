using System;
using System.Collections.Generic;


namespace curse01
{
    class Program
    {
        static void Main(string[] args)
        {
            info[] hotel = new info[10];

            System.Console.WriteLine("How Rooms Will be Rented");
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                System.Console.WriteLine($"Ren #{i}:");
                System.Console.Write("Name: ");
                string name = Console.ReadLine();
                System.Console.Write("Email: ");
                string email = Console.ReadLine();
                System.Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                hotel[room] = new info(name, email);


            }

            System.Console.WriteLine("Busy Room:");
            for (int i = 0; i < 10; i++)
            {

                if (hotel[i] != null)
                {

                    System.Console.WriteLine(i + ": " + hotel[i]);

                    System.Console.WriteLine("hello");



                }

            }

















        }
    }
}
