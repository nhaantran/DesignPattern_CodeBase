

namespace DesignPattern_Example.OnTapLan2.AbstractFactory.Product
{
    public class NormalDessertProduct : IDessertProduct
    {
        public string PrepareDessertMeal()
        {
            var mealPlan = "Trái cây, bánh ngọt, hạt < 500gr";
            return mealPlan;
        }
    }
}
