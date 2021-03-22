using System;
using System.Reflection;
using System.Collections.Generic;
using TesteFactoryMethod.Projeto_Prático.ConcreteCreators;

namespace TesteFactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //new Client().Main(); --> Projeto Modelo
            
            var lancheFrango = new LancheFrango();
            var lanchePeru = new LanchePeru();

            ListaItens(lancheFrango.Ingredientes, "Frango");
            ListaItens(lanchePeru.Ingredientes, "Peru");

            Console.ReadLine();
        }

        private static void ListaItens(List<Ingrediente> l, string lanche)
        {
            Console.WriteLine("Igredientes do lanche de " + lanche + ":");
            foreach (Ingrediente i in l)
            {
                Console.WriteLine(i.ToString().Replace("TesteFactoryMethod.", ""));
            }
        }

       
    }
}
