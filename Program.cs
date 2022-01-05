using System;
using System.Collections.Generic;

namespace ProjetoCTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Cliente> cliente = new List<Cliente>();
            cliente.Add(new Cliente("Luiz", "Endereço", true));
            cliente.Add(new Cliente("Otávio", "Endereço", true));
            cliente.Add(new Cliente("Olinger Momm", "Endereço", true));

            foreach (Cliente linha in cliente)
            {
                Console.WriteLine(linha);
            }

        }
    }
}
