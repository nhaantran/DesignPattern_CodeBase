

namespace DesignPattern_Example.OnTapLan2.AbstractFactory.Product
{
    public class LoseWeightDessertProduct : IDessertProduct
    {
        public string PrepareDessertMeal()
        {
            var mealPlan = "Trái cây < 200gr";
            return mealPlan;
        }
    }
}
