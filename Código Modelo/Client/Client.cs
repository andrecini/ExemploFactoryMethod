using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteFactoryMethod
{
    class Client
    {
        /// <summary>
        /// Métodos Main, sempre são executados primeiro
        /// </summary>
        public void Main()
        {
            Console.WriteLine("App: Launched with the ConcreteCreator1.");
            ClientCode(new ConcreteCreator1());

            Console.WriteLine("");

            Console.WriteLine("App: Launched with the ConcreteCreator2.");
            ClientCode(new ConcreteCreator2());
        }

        /// <summary>
        /// O código do cliente trabalha com uma instância do Concrete
        /// Creator, embora por meio de sua interface de base. Contanto
        /// que o cliente continue trabalhando com o Creator via interface
        /// base, você pode qualquer subclasse do Creator.
        /// </summary>
        /// <param name="creator"></param>
        public void ClientCode(Creator creator)
        {
            Console.WriteLine("Client: I'm not aware of the creator's class," 
                                            +  "but it still works.\n" 
                                            + creator.SomeOperation());
        }
    }
}
