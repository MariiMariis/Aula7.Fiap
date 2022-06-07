using Aula7.Fiap.Ex3;
using System;

namespace Aul7.Fiap.Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exemplo de polimorfismo em tempo de compilação, onde há
            // sobrecarga de métodos

            Calcular calcular = new Calcular();
            calcular.Soma(1, 2);
            calcular.Soma(1, 2, 3);
        }
    }
}
