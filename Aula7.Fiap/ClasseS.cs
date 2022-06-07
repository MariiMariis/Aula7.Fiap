using System;
using System.Collections.Generic;
using System.Text;

namespace Aula7.Fiap
{
    // Classe selada, não permitindo que outras classes herdem dela
    public sealed class ClasseS
    {
        public void Mensagem()
        {
            Console.WriteLine("Sou uma classe selada.");
        }

    }
}
