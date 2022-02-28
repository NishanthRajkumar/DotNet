namespace CoffeeMaker;

public class StarbuckStore
{
    private readonly IMakeACoffee service;
    public StarbuckStore(IMakeACoffee service)
    {
        this.service = service;
    }

    public string OrderCoffee(int sugarPerSpoon, int coffeeCount)
    {
        if (service.CheckIngredientAvailability())
        {
            return service.CoffeeMaking(sugarPerSpoon, coffeeCount);
        }
        else
        {
            return "Sorry! Coffee is not available.";
        }
    }

}
