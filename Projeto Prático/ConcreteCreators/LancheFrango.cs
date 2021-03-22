using TesteFactoryMethod.Projeto_Prático.Creator;

namespace TesteFactoryMethod.Projeto_Prático.ConcreteCreators
{
    class LancheFrango : Lanche
    {
        public override void CriaIngredientes()
        {
            Ingredientes.Add(new Pao());
            Ingredientes.Add(new Frango());
            Ingredientes.Add(new Alface());
            Ingredientes.Add(new Maionese());
            Ingredientes.Add(new Tomate());
        }
    }
}
