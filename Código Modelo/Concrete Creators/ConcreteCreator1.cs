using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteFactoryMethod
{
    /// <summary>
    /// Concrete Creators substituem o Factory method em ordem para
    /// mudar o typo de produto resultante.
    /// </summary>
    class ConcreteCreator1 : Creator
    {
        //Note que a assinatura do método continua usando o tipo de
        //produto abstrato (no caso, uma interface), enquanto o método
        //retorna um Concret Product.
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }
}
