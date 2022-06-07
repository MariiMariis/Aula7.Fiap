using System;
using System.Collections.Generic;
using System.Text;
using Aula7.Fiap.Ex5.Models;

namespace Aula7.Fiap.Ex5.Models
{
    //Classe derivada carro, que herda da classe base BaseCarro e também da Interface ICor
    class Carro : BaseCarro, ICor
    {

        public Carro(string nomeCarro) : base(nomeCarro)
        {
        }

        //Quando herdamos de uma interface, devemos implementar todos os seus métodos

        public void CorCarro(string cor)
        {
            Console.WriteLine($"O carro é da cor {cor}");
        }
    }
}
