using System;
using System.Collections.Generic;
using System.Text;

namespace Aula7.Fiap.Ex5.Models
{
    class BaseCarro
    {

        // Construtor que recebe um nome para o carro
        public BaseCarro(string nomeCarro)
        {
            Console.WriteLine($"Esse carro é um {nomeCarro}");
        }

        //Método que retorna um tipo de motor
        public void Motor1()
        {
            Console.WriteLine("Motor V.1");
        }

        //Método que retorna um tipo de motor
        public void Motor2()
        {
            Console.WriteLine("Motor V.2");
        }

        //Método que retorna um tipo de motor
        public void Motor3()
        {
            Console.WriteLine("Motor V.3");
        }
        //Método que retorna o tipo de pneu
        public void Pneu()
        {
            Console.WriteLine("O pneu é de para neve");
        }

        //Método que retorna o tipo de sistema de som
        public void SistemaSom()
        {
            Console.WriteLine("Sitema de som Dolby");
        }
    }
}
