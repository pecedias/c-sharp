﻿using System;
using System.Collections.Generic;

namespace ConsoleApp5 {
    class Program {
        static void Main(string[] args) {

            List<string> list = new List<string>();

            list.Add("Maria"); // Add sempre adiciona o dado ao final da lista
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco"); // Insert pode escolher em qual posição colocar o dado na lista

            foreach (var obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'A'); // Expressão lambda "expressão anônima"
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("------------------------");
            foreach (var obj in list2) {
                Console.WriteLine(obj);
            }

            list.Remove("Alex");
            Console.WriteLine("------------------------");
            foreach (var obj in list) {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("------------------------");
            foreach (var obj in list) {
                Console.WriteLine(obj);
            }

            list.RemoveAt(3);
            Console.WriteLine("------------------------");
            foreach (var obj in list) {
                Console.WriteLine(obj);
            }

            list.RemoveRange(2, 2);

        }
        /*       
                static bool Test(string s) { // Predicado
                   return s[0] == 'A';
               }
       */
    }
}
