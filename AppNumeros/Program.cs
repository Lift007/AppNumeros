using System;
using System.Collections.Generic;
using System.Linq;

namespace AppNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Digite um número: ");
                string dado = Console.ReadLine();

                // Validação
                if (!Int32.TryParse(dado, out Int32 numero))
                {
                    Console.WriteLine("O dado informado é inválido, digite um número inteiro!");
                }
                else
                {
                    if (numero > 10000000)
                    {
                        Console.WriteLine("Aguarde o processamento...");
                    }

                    // Lista de números divisores
                    List<int> divisores = new List<int>();
                    for (int i = 1; i <= numero; i++)
                    {
                        if ((numero % i) == 0)
                        {
                            divisores.Add(i);
                        }
                    }

                    // Lista de números divisores primos
                    List<int> divisoresPrimos = new List<int>();
                    foreach (int item in divisores.Distinct())
                    {
                        bool primo = true;
                        int contador = item - 1;
                        while (contador > 2)
                        {
                            if (item % contador == 0)
                            {
                                primo = false;
                                break;
                            }
                            contador--;
                        }

                        if (primo == true)
                        {
                            divisoresPrimos.Add(item);
                        }
                    }

                    Console.WriteLine("Números divisores: " + String.Join(", ", divisores.Distinct()));
                    Console.WriteLine("Divisores primos: " + String.Join(", ", divisoresPrimos.Distinct()));

                    Console.WriteLine();
                    Console.Write("Deseja continuar? (S/N) ");
                    string continua = Console.ReadLine();
                    if (!continua[0].ToString().ToUpper().Equals("S"))
                    {
                        return;
                    }
                    else
                    {
                        Console.Clear();
                    }
                }
            } while (true);
        }
    }
}
