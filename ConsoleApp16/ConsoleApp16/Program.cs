﻿using System;
using System.Globalization;

namespace ConsoleApp16 {

    class Program {
        static void Main(string[] args) {

            Produto p = new Produto("TV", 500.00, 10);

            //            p.SetNome("T");
            //            Console.WriteLine(p.GetNome());

            p.Nome = "TV 4K";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);

        
        }
    }

}