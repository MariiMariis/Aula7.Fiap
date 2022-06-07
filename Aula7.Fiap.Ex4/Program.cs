using System;

namespace Aula7.Fiap.Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario();
            usuario.PegarInfo();

            Admin administrador = new Admin();
            administrador.PegarInfo();

        }
    }
}
