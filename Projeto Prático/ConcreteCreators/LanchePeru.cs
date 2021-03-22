using TesteFactoryMethod.Projeto_Prático.Creator;

namespace TesteFactoryMethod.Projeto_Prático.ConcreteCreators
{
    class LanchePeru : Lanche
    {
        public override void CriaIngredientes()
        {
            Ingredientes.Add(new Pao());
            Ingredientes.Add(new Peru());
            Ingredientes.Add(new Alface());
            Ingredientes.Add(new Maionese());
        }
    }
}

