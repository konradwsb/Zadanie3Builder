public class ConcretePizzaBuilder : IPizzaBuilder
{
    private Pizza pizza = new Pizza();

    public void BuildDough(string dough) { pizza.Dough = dough; }
    public void BuildMeat(string meat) { pizza.Meat = meat; }
    public void BuildCheese(string cheese) { pizza.Cheese = cheese; }
    public void BuildVeggies(string veggies) { pizza.Veggies = veggies; }
    public void BuildSpices(string spices) { pizza.Spices = spices; }

    public Pizza GetPizza() { return pizza; }
}