public interface IPizzaBuilder
{
    void BuildDough(string dough);
    void BuildMeat(string meat);
    void BuildCheese(string cheese);
    void BuildVeggies(string veggies);
    void BuildSpices(string spices);
    Pizza GetPizza();
}