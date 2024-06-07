public class Pizza
{
    public string Dough { get; set; }
    public string Meat { get; set; }
    public string Cheese { get; set; }
    public string Veggies { get; set; }
    public string Spices { get; set; }

    public override string ToString()
    {
        return $"Pizza with {Dough} dough, {Meat} meat, {Cheese} cheese, {Veggies} veggies, and {Spices} spices.";
    }
}