using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteFactoryMethod
{
    /// <summary>
    /// A interface de Products declara as operações que todos os 
    /// Concrete Products DEVEM IMPLEMENTAR.
    /// </summary>
    interface IProduct
    {
        string Operation();
    }
}
