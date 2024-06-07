public class PizzaDirector
{
    private IPizzaBuilder builder;

    public PizzaDirector(IPizzaBuilder builder) { this.builder = builder; }

    public void ConstructPizza(string dough, string meat, string cheese, string veggies, string spices)
    {
        builder.BuildDough(dough);
        builder.BuildMeat(meat);
        builder.BuildCheese(cheese);
        builder.BuildVeggies(veggies);
        builder.BuildSpices(spices);
    }
}