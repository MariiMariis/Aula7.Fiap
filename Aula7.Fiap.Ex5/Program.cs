using Aula7.Fiap.Ex5.Models;
using System;

namespace Aula7.Fiap.Ex5
{
    class Program
    {
        static void Main(string[] args)
        {

            // Instanciando um objeto 'ferrari' à partir da classe Carro
            Carro ferrari = new Carro("Ferrari");

            ferrari.Motor3();
            ferrari.Pneu();
            ferrari.CorCarro("Vermelho sangue");
            ferrari.SistemaSom();

            //Divisor de objetos no console
            Console.WriteLine("\n***************************\n");

            // Instanciando um objeto 'focus' à partir da classe Carro
            Carro focus = new Carro("Focus");

            ferrari.Motor1();
            ferrari.Pneu();
            ferrari.CorCarro("Branco perolado");
            ferrari.SistemaSom();

        }
    }
}
