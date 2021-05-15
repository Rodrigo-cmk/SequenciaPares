using System;

namespace SequenciaPares
{
    class Program
    {
        static void Main(string[] args)
        {
            boasVindas();
            codigo();
        }

        static void boasVindas()
        {
            DateTime agora = DateTime.Now;

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Olá!!             {agora}");
            Console.WriteLine();

            Console.WriteLine("----- SequenciaPares -----");
            Console.WriteLine("Recepção de um número inteiro positivo. Exibição de todos os números pares entre zero e o número digitado (inclusive).");
            Console.ResetColor();
        }

        static void codigo()
        {
            string c;

            do
            {
                int a;

                Console.WriteLine();
                Console.Write("--> Insira um número inteiro: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                for (int b = 0; b <= a; b = b + 2)
                {
                    Console.Write($" {b} ");
                }
                Console.ResetColor();

                if (a < 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Caractere inválido.");
                    Console.ResetColor();
                    Environment.Exit(-1);
                }

                Console.WriteLine();
                Console.WriteLine();

                Console.Write("Continuar (");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("'Sim' ");
                Console.ResetColor();
                Console.Write("/ ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Qualquer tecla para 'Não'");
                Console.ResetColor();
                Console.Write(")?  ");
                c = Console.ReadLine().ToUpper();
            } while (c == "SIM");

            Console.WriteLine();
            Console.WriteLine("Obrigado!");
        }
    }
}
