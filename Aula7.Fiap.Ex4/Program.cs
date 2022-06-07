using System;

namespace Aula7.Fiap.Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instanciando objeto à partir da classe base
            Usuario usuario = new Usuario();
            usuario.PegarInfo();

            //instanciando objeto à partir da classe derivada, que sobrescreve o método da classe base
            Admin administrador = new Admin();
            administrador.PegarInfo();

        }
    }
}
