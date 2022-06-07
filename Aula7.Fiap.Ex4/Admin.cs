using System;
using System.Collections.Generic;
using System.Text;

namespace Aula7.Fiap.Ex4
{
    class Admin : Usuario
    {
        // Classe derivada, com método do tipo override, que permite sobrescrição da classe base
        //Polimorfismo em tempo de execução significa sobrescrever um método de uma classe base
        // na classe derivada, criando uma função similar. (late binding ou dynamic binding)
        public override void PegarInfo()
        {
            Console.WriteLine("Classe derivada");
        }
    }
}
