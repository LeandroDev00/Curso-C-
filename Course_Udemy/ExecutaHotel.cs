using System;
using System.Globalization;
using hotelaria;

namespace ExecutarHotel
{
    public class Hotel
    {
        public static void RunHotel()
        {
            Estudante[] vect = new Estudante[10];
            Console.Write("How many rooms will be rented ?: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Rent #{i}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                Console.WriteLine();
                vect[room] = new Estudante(name, email, room);

                Console.WriteLine("Busy rooms:");
                for (int j = 1; j < vect.Length; j++)
                {
                    if (vect[j] != null)
                    {
                        Console.WriteLine(vect[j].Rooms + ": " + vect[j].Name + ", " + vect[j].Email);
                    }
                }
            }
        }
    }
}
