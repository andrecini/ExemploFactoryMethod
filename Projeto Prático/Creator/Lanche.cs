using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteFactoryMethod.Projeto_Prático.Creator
{
    public abstract class Lanche
    {
        private List<Ingrediente> ingredientes = new List<Ingrediente>();

        public Lanche()
        {
            CriaIngredientes();
        }

        //método Factory
        public abstract void CriaIngredientes();

        public List<Ingrediente> Ingredientes
        {
            get { return ingredientes; }
        }
    }
}
