namespace Architecture;

public abstract class ExteriorDesign : IDesign
{
    public void BluePrint()
    {
        Console.WriteLine("Design foundation parameters, types of materials, size, exterior design");
    }

    public void Impementation()
    {
        throw new NotImplementedException();
    }

    public void Maintenance()
    {
        throw new NotImplementedException();
    }

    public abstract void Workers();
}
