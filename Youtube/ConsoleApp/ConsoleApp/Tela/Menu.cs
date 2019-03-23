using Calculo;
using Diretorio;
using Funcoes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tela {
    class Menu {
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;

        public static void Criar() {
            while (true) {
                string mensagem = "\nOlá usuário, bem vindo ao programa:\n" +
                                  "\n\n" +
                                  "\n  Utilizando Programação Funcional!" +
                                  "\n    Digite uma das opções abaixo:" +
                                  "\n      0 - Sair do programa" +
                                  "\n      1 - Ler arquivos" +
                                  "\n      2 - Executar tabuada" +
                                  "\n      3 - Calcular média de alunos";
                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (valor == SAIDA_PROGRAMA) {
                    break;
                }
                else if (valor == LER_ARQUIVOS) {
                    Console.WriteLine("================= Opção Ler arquivos =====================");
                    Arquivo.Ler(1);
                    Console.WriteLine("==========================================================");
                }
                else if (valor == TABUADA) {
                    Console.WriteLine("================= Opção Tabuada =====================");
                    Console.WriteLine("Digite o número que deseja na tabuada:");
                    int numero = int.Parse(Console.ReadLine());
                    Tabuada.Calcular(numero);
                    Console.WriteLine("==========================================================");
                }
                else if (valor == CALCULO_MEDIA) {
                    Console.WriteLine("================= Opção Cálculo da média =====================");
                    Media.Aluno();
                    Console.WriteLine("==========================================================");
                }
                else {
                    Console.WriteLine("Opção inválida, digite novamente! =/");
                    Console.WriteLine("==========================================================");
                }
            }
        }
    }
}
