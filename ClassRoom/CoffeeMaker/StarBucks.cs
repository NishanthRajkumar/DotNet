namespace CoffeeMaker;

public class Starbucks : IMakeACoffee
{
    public bool CheckIngredientAvailability()
    {
        return true;
    }

    public string CoffeeMaking(int sugerPerSpoon, int CoffeePack)
    {
        return "Your Order is received.";
    }
}

public class StubStarbucks : IMakeACoffee
{
    public bool CheckIngredientAvailability()
    {
        return true;
    }

    public string CoffeeMaking(int sugerPerSpoon, int CoffeePack)
    {
        return "Your order is received.";
    }
}
