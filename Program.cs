using System;
using System.Collections.Generic;

namespace entregavelUC4
{
    class Program
    {
        static char escolha = 's';

        static void Main(string[] args)
        {

            do
            {
                escolhaExercicio();

            } while (escolha == 's');

            Console.ReadKey();
        }

        static void escolhaExercicio(){
            int exercicio;

            Console.Write("Digite o exercício a ser exibido: ");
            exercicio = Convert.ToInt32(Console.ReadLine());

            switch (exercicio)
            {
                case 1:
                    exercicio01();
                    break;
                case 2:
                    exercicio02();
                    break;
                case 3:
                    exercicio03();
                    break;
                case 4:
                    exercicio04();
                    break;
                case 5:
                    exercicio05();
                    break;
                case 6:
                    exercicio06();
                    break;
                case 7:
                    exercicio07();
                    break;
                case 8:
                    exercicio08();
                    break;
                case 9:
                    exercicio09();
                    break;
                case 10:
                    exercicio10();
                    break;
                default:
                    Console.WriteLine("Exercício inválido!");
                    break;
            }

            Console.Write("Deseja ver outro exercício? S ou N ?");
            escolha = Convert.ToChar(Console.ReadLine().ToLower());
            Console.WriteLine("");
        }

        // Escreva um programa em C# para exibir uma sequência de números na ordem inversa.
        static void exercicio01()
        {
            string sequencia;

            Console.WriteLine("Digite uma sequencia de números:");
            sequencia = Console.ReadLine();

            char[] array = sequencia.ToCharArray();
            Array.Reverse(array);

            Console.WriteLine(array);
        }


        // Escreva um programa C# para encontrar os números perfeitos dentro de um determinado intervalo de número.
        static void exercicio02()
        {
            int inicial, final, value;
            List<int> perfects = new List<int>();

            Console.WriteLine("Digite o primeiro número:");
            inicial = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o último número:");
            final = Convert.ToInt32(Console.ReadLine());

            value = inicial;

            while (value <= final)
            {
                int sum = 0;

                for (int cnt = 1; cnt < value; ++cnt)

                    if ((value % cnt) == 0) sum += cnt;

                if (value == sum)
                {
                    perfects.Add(value);
                }

                value++;
            }

            Console.Write("Os números perfeitos no intervalo dado é: ");
            perfects.ForEach(item => Console.Write(item + " "));

            Console.WriteLine("");
        }


        // Escreva um programa C# para determinar se um dado número é primo ou não.
        static void exercicio03()
        {
            Console.Write("Digite um número: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (chkprime(n))
                Console.WriteLine(n + " é um número primo");
            else
                Console.WriteLine(n + " não é um número primo");

            bool chkprime(int num)
            {
                for (int i = 2; i < num; i++)
                    if (num % i == 0)
                        return false;
                return true;
            }
        }

        // Uma pessoa só pode votar em eleições brasileiras se ela for maior que 16 anos e for cidadã brasileira.
        // Crie um programa com duas variáveis, int idade, bool brasileira, e faça com que o programa diga se a pessao está apta a votar ou não, de acordo com os dados nas variáveis.
        static void exercicio04()
        {
            int idade;
            bool brasileira;

            Console.WriteLine("Digite sua idade:");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade <16) {
                Console.WriteLine("Não pode votar.");
            } else {
                Console.WriteLine("Você tem nacionalidade brasileira?");
                Console.WriteLine("V ou F");
                if (Console.ReadLine().ToLower() == "v")
                {
                    brasileira = true;
                }
                else
                {
                    brasileira = false;
                }

                if(brasileira == true) {
                    Console.WriteLine("Pode votar.");
                } else {
                    Console.WriteLine("Não pode votar.");
                }
            }
        }


        // Faça um programa em C# que imprima todos os múltiplos de 3, entre 1 e 100.
        static void exercicio05()
        {
            for (int i = 1; i * 3 < 101; i++)
            {
                Console.WriteLine(i * 3);
            }
        }

        // Escreva um programa em C# que imprime todos os números que são divisíveis por 3 ou por 4 entre 0 e 30.
        static void exercicio06()
        {
            for (int i = 0; i < 31; i++)
            {
                if ((i % 3 == 0) || (i % 4 == 0))
                {
                    Console.WriteLine(i);
                }
            }
        }

        // Crie um programa em C# que imprima os fatoriais de 1 a 10.
        // O fatorial de um número n é n n-1 n-2 ... até n = 1.
        static void exercicio07()
        {
            int fatorial = 1;
           
            for (int n = 1; n <= 10; n++)
            {
                fatorial = fatorial * n;
                Console.WriteLine("O fatorial de "+n+" é (" + (n-1) + "!) * " + (n) + " = " + fatorial);
            }

            Console.WriteLine("");
        }

        //Faça um programa em C# que imprima os primeiros números da série de Fibonacci até passar de 100
        // A série de Fibonacci é a seguinte: 0, 1, 1, 2, 3, 5, 8, 13, 21 etc..
        // Para calculá-la, o primeiro elemento vale 0, o segundo vale 1, daí por diante, o n-ésimo elemento vale o(n-1)-ésimo elemento somado ao(n-2)- ésimo elemento(ex: 8 = 5 + 3).
        static void exercicio08()
        {
            int a = 0, fib = 1;

            while (fib <= 100)
            {
                Console.Write(a + " " + fib + " ");
                a += fib;
                fib += a;
            }

            Console.WriteLine("");

        }

        // Faça um programa que imprima a seguinte tabela, usando for encadeados:
        // 1 
        // 2 4
        // 3 6 9
        // 4 8 12 16
        // n n*2 n*3 .... n* n
        static void exercicio09()
        {
            int linhas;

            Console.Write("Digite o número de linhas: ");
            linhas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("1");

            for (int i = 2; i <= linhas; i++){
                for (int j = 1; j <= i; j++){
                    Console.Write(i * j+" ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("");
        }

        // Escreva um programa em C# para fazer um padrão como uma pirâmide com um asterisco:
        //     *
        //    * *
        //   * * *
        //  * * * *
        static void exercicio10()
        {
            int num, i, j, k;
            Console.Write("Digite o número de linhas: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            for (i = 1; i <= num; i++)
            {
                for (j = 1; j < num - i + 1; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();

            }

            Console.WriteLine("");
        }
    }
}