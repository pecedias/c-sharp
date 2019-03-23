using System;

namespace ConsoleApp23 {
    class Program {
        static void Main(string[] args) {

            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            Rent[] vect = new Rent[10];

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Rent #" + i);

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                vect[room] = new Rent { Name = name, Email = email, Room = room };
                Console.WriteLine();
            }

            Console.WriteLine("Busy rooms:");

            for (int i = 0; i < 9; i++) {
                if (vect[i] != null)
                    Console.WriteLine("{0}: {1}, {2}", vect[i].Room, vect[i].Name, vect[i].Email);
            }
        }
    }
}
