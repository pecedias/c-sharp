using Classes;
using System;
using System.Collections.Generic;
using Tela;

/*
 * Quando se usar static, é só pensar que é uma ação para várias pessoas de uma vez, não somente 1
 */

namespace ConsoleApp {
    class Program {
        static void Main(string[] args) {
            //Menu.Criar();
            
            var cliente = new Cliente();
            cliente.Nome = "Jose";
            cliente.Telefone = "8484948484";
            cliente.CPF = "998944849858";
            cliente.Gravar();

            // Cliente c = new Cliente();

            // Cliente c2 = new Cliente { Nome = "danilo", Telefone = "abcdef", CPF = "ghijkl" };

            var clientes = Cliente.LerClientes();
            foreach (Cliente c in clientes) {
                Console.WriteLine(c.Nome);
                Console.WriteLine(c.Telefone);
                Console.WriteLine(c.CPF);

            }

            Console.ReadLine();

           // var l = new List<string>();

            /*
            var cliente2 = new Cliente();
            cliente2.Nome = "Sheila";
            cliente2.Telefone = "33484568484";
            cliente2.CPF = "90689595899";
            cliente2.Gravar();
            */
        }
    }
}