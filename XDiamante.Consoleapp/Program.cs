namespace XDiamante.Consoleapp;
using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Digite um número ímpar (ou 0 para sair): ");
            int numero = int.Parse(Console.ReadLine());

            if (numero == 0)
            {
                Console.WriteLine("Programa encerrado.");
                break;
            }

            if (numero % 2 == 0)
            {
                Console.WriteLine("Por favor, digite um número ímpar.");
                continue;
            }

            DesenharDiamante(numero);

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }

    static void DesenharDiamante(int numero)
    {
        int meio = numero / 2;

        for (int i = 0; i <= meio; i++)
        {
            DesenharLinha(numero, i, meio);
        }

        for (int i = meio - 1; i >= 0; i--)
        {
            DesenharLinha(numero, i, meio);
        }
    }

    static void DesenharLinha(int numero, int linhaAtual, int meio)
    {
        int espacos = Math.Abs(meio - linhaAtual);
        int caracteres = numero - (2 * espacos);

        for (int i = 0; i < espacos; i++)
        {
            Console.Write(" ");
        }

        for (int i = 0; i < caracteres; i++)
        {
            Console.Write("x");
        }

        Console.WriteLine();
    }
}
