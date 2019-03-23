using System;
using System.Collections.Generic;

namespace ConsoleApp24 {
    class Program {
        static void Main(string[] args) {

            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            int Cod;
            int N;

            Console.WriteLine("O curso A possui quantos alunos?");
            N = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < N; i++) {
                Cod = int.Parse(Console.ReadLine());
                A.Add(Cod);
            }
            Console.WriteLine("O curso B possui quantos alunos?");
            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++) {
                Cod = int.Parse(Console.ReadLine());
                B.Add(Cod);
            }
            Console.WriteLine("O curso C possui quantos alunos?");
            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++) {
                Cod = int.Parse(Console.ReadLine());
                C.Add(Cod);
            }

            HashSet<int> Novo = new HashSet<int>();
            Novo.UnionWith(A);
            Novo.UnionWith(B);
            Novo.UnionWith(C);

            Console.WriteLine("Total de Alunos: " + Novo.Count);

        }
    }
}
