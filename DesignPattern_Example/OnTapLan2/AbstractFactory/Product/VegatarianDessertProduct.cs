namespace DesignPattern_Example.OnTapLan2.AbstractFactory.Product
{
    public class VegatarianDessertProduct : IDessertProduct
    {
        public string PrepareDessertMeal()
        {
            var mealPlan = "Trái cây, bánh ngọt 300-500gr";
            return mealPlan;
        }
    }
}
