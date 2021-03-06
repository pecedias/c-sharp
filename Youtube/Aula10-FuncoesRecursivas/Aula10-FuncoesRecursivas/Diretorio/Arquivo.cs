﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Configuration;

namespace Diretorio {
    class Arquivo {
        public static void Ler(int numeroArquivo) {
            //   string caminhoArquivo = @"D:\Dev\C#\Youtube\Arquivos\arq" + numeroArquivo + ".txt"; // @ Para não dar incompatibilidade com as barras
            string caminhoArquivo = ConfigurationManager @"D:\Dev\C#\Youtube\Arquivos\arq" + numeroArquivo + ".txt";
            Console.WriteLine("=============== Lendo arquivo ===============\n" + caminhoArquivo + "\n=============================================");
            if (File.Exists(caminhoArquivo)) {
                using (StreamReader arquivo = File.OpenText(caminhoArquivo)) {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null) {

                        Console.WriteLine(linha.ToUpper());
                    }
                }
            }
            string caminhoArquivo2 = @"D:\Dev\C#\Youtube\Arquivos\arq" + (numeroArquivo + 1) + ".txt";
            if (File.Exists(caminhoArquivo2)) {
                Arquivo.Ler(numeroArquivo + 1);
            }
        }
    }
}
