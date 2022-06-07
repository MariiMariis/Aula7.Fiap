using System;
using System.Collections.Generic;
using System.Text;

namespace Aula7.Fiap.Ex3
{
    public class Calcular
    {
        //Polimorfismo de tempo de compilação
        //Dois métodos com o mesmo nome, porém passando parâmetros diferentes


        //Método que recebe 2 parâmetros
        public void Soma(int a, int b )
        {
            Console.WriteLine($"a + b = {a + b}");
        }

        //Método que recebe 3 parâmetros
        public void Soma(int a, int b, int c)
        {
            Console.WriteLine($"a + b + c = {a + b + c}");
        }


    }
}
