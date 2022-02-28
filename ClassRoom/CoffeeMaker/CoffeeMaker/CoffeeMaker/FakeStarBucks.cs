namespace CoffeeMaker;

public class FakeStarbucksStore : IMakeACoffee
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

