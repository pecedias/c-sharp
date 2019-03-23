using System;

namespace ConsoleApp2 {
    class Program {
        static void Main(string[] args) {

            int a = 10;            

            Calculator.Triple(ref a);
            Console.WriteLine(a);

            int b = 10;
            int triple;

            Calculator.TripleOut(b, out triple);
            Console.WriteLine(b);
            Console.WriteLine(triple);

        }
    }
}
