using System;
using POO_Polimorfismo_Sobrecarga_.classes;

namespace POO_Polimorfismo_Sobrecarga_
{
    class Program
    {
        static void Main(string[] args)
        {
           //instanciamos nossa classe funcinario
           Funcionarios fun = new Funcionarios();
           fun.Mostrar();
           fun.Mostrar("Nicolas");
           fun.Mostrar(3);
           

           Console.Beep();

        }
    }
}
