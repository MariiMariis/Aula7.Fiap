using System;
using System.Collections.Generic;
using System.Text;

namespace Aula7.Fiap.Ex4
{
    class Usuario
    {
        // Classe base, com método do tipo virtual, que permite sobrescrição
        //Polimorfismo em tempo de execução significa sobrescrever um método de uma classe base
        // na classe derivada, criando uma função similar. (late binding ou dynamic binding)
        public virtual void PegarInfo()
        {
            Console.WriteLine("Classe base");
        }
    }
}
