

namespace DesignPattern_Example.OnTapLan2.AbstractFactory.Product
{
    internal class HealingDessertProduct : IDessertProduct
    {
        public string PrepareDessertMeal()
        {
            var mealPlan = "Các hạt < 100gr";
            return mealPlan;
        }
    }
}
