using System;
using System.Collections.Generic;

namespace Aula7.Fiap.Ex2
{
     class Program
    {
        static void Main(string[] args)
        {
            // Criando uma lista de nomes do tipo string
            var nomes = new List<string>();

            // Adicionando nomes à lista
            nomes.Add("Vanessa");
            nomes.Add("Franklin");
            nomes.Add("Vinicius");
            nomes.Add("Gabriel");
            nomes.Add("Cleber");
            nomes.Add("Gustavo");
            nomes.Add("Fabrício");
            nomes.Add("Geovane");
            nomes.Add("Luan");

            //Lista populada com nomes na hora da criação
            var nomes2 = new List<string>() 
            { 
                "Cora", "Mimi", "Sebastian", "Jordi" 
            };


            // Passar por cada item da lista e imprimi-los no console
            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }

            // Passar por cada item da lista e imprimi-los no console
            foreach (var item in nomes2)
            {
                Console.WriteLine(item);
            }



        }
    }
}
