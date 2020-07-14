using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            bool terminar = false;
            int N;
            int x = 0;
            int y = 1;
            while (!terminar)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\nQuantos termos da sequência de Fibonacci você deseja ver? (>=2)\t");
                bool nbool = Int32.TryParse(Console.ReadLine(), out N);
                if (!nbool || N < 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Valor inválido, pressione uma tecla para inserir outro valor.");
                    Console.ResetColor();
                    Console.ReadKey();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    int menos = N - 2;
                    Console.Write($"{x} {y} ");
                    for (int i = 1; i <= menos; i++)
                    {
                        int result = x + y;
                        Console.Write($"{result} "); 
                        x = y;
                        y = result;
                    }
                    Console.ResetColor();
                    Console.WriteLine("\nPressione uma tecla para finalizar o programa.");
                    Console.ReadKey();
                    terminar = true;
                }
            }
        }
    }
}
