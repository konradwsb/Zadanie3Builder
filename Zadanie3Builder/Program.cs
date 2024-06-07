
public class Program
{
    public static void Main(string[] args)
    {
        do
        {
            IPizzaBuilder builder = new ConcretePizzaBuilder();
            PizzaDirector director = new PizzaDirector(builder);

            Console.WriteLine("Choose crust (e.g., Thin Crust, Thick Crust):");
            string dough = Console.ReadLine();

            Console.WriteLine("Choose meat (e.g., Pepperoni, Ham):");
            string meat = Console.ReadLine();

            Console.WriteLine("Choose cheese (e.g., Mozzarella, Cheddar):");
            string cheese = Console.ReadLine();

            Console.WriteLine("Choose veggies (e.g., Peppers, Onions):");
            string veggies = Console.ReadLine();

            Console.WriteLine("Choose spices (e.g., Oregano, Basil):");
            string spices = Console.ReadLine();

            director.ConstructPizza(dough, meat, cheese, veggies, spices);
            Pizza pizza = builder.GetPizza();
            Console.WriteLine(pizza);

            Console.WriteLine("Would you like to order another pizza? (yes/no)");
        } while (Console.ReadLine().ToLower() == "yes");

    }
}


