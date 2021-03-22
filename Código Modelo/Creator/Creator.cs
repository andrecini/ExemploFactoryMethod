using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteFactoryMethod
{
    /// <summary>
    /// A classe creator declara o Factory Method que deve retornar um objeto 
    /// de uma classe Product. As subclasses de Creator, normalmente, promove
    /// a implementação deste método.
    /// </summary>
    abstract class Creator
    {
        //Note que o Creator só pode promover uma implementação padrão
        //do Factory Method
        public abstract IProduct FactoryMethod();

        //Note também que, independentemente do nome, a principal respon-
        //sabilidade do Creator não é produzir produtos. Normalmente, ele 
        //contém alguma lógica que depende dos objetos Products, retornado
        //pelo Factory Method. Subclasses podem, indiretamente,  mudar
        //essa lógica substituindo o método de fábrica e retornando um tipo 
        //diferente de produto a partir dele.
        public string SomeOperation()
        {
            var product = FactoryMethod();

            var result = "Creator: The same creator's code has just worked with "
                                + product.Operation();
            return result;
        }
    }
}
