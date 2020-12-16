using System;

namespace POO_Polimorfismo_Sobrecarga_.classes
{
    public class Funcionarios
    {
        public string[] lista = {"Junior", "Nicolas", "Rafael", "Maicon"};

        public void Mostrar(){
            
            //Imprimimos todos os metodos que estao nno array
            foreach (var item in lista)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(item);
                Console.ResetColor();
            }
        }
            //Mostramos apenas o dado que esta no indice que esta no arrey
            public void Mostrar(int indice){
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(lista[indice]);
                Console.ResetColor();
            }

            public void Mostrar(string busca){
                //Fazemos uma busca no arrey para verificar se os textos coicidem
                foreach (var item in lista)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    if (item == busca)
                    {
                        Console.WriteLine("Resultado da busca :" + item);
                    }

                    Console.ResetColor();
                }

            }
        
    }
}