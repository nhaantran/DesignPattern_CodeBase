using DesignPattern_Example.OnTapLan2.AbstractFactory.Product;

namespace DesignPattern_Example.OnTapLan2.AbstractFactory.Diet
{
    public class NormalDiet : IDietFactory
    {
        public void PrepareForAppetizer()
        {
            throw new NotImplementedException();
        }

        public void PrepareForDessert()
        {
            var product = new NormalDessertProduct();
            Console.WriteLine($"Meal plan: {product.PrepareDessertMeal()}");
        }

        public void PrepareForMainMeal()
        {
            throw new NotImplementedException();
        }
    }
}
