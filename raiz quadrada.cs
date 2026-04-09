// Nome:GIOVANNA

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        double numero = double.Parse(Console.ReadLine());

        double raiz = Math.Sqrt(numero);

        Console.WriteLine("A raiz quadrada é: " + raiz);
    }
}