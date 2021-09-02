using System;
using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c;

            Console.WriteLine("Conta Bancária");
            Console.WriteLine();

            Console.Write("Digite o número da conta a ser cadastrada: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do Titular: ");
            string titular = Console.ReadLine();
            Console.Write("Deseja fazer um depósito inicial: S/N: ");
            char resp = char.Parse(Console.ReadLine().ToUpper());
            double deposito;

            if (resp == 'S')
            {
                Console.Write("Digite o valor do depósito inicial: ");
                deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new Conta(numero, titular, deposito);
                
            }

            else
            {
                c = new Conta(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Conta atualizada: ");
            Console.WriteLine(c);

            Console.WriteLine();
            Console.Write("Digite o valor para depósito: ");
            deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Deposito(deposito);

            Console.WriteLine();
            Console.WriteLine("Conta atualizada: ");
            Console.WriteLine(c);

            Console.WriteLine();
            Console.Write("Digite o valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Saque(saque);

            Console.WriteLine();
            Console.WriteLine("Conta atualizada: ");
            Console.WriteLine(c);

        }
    }
}
