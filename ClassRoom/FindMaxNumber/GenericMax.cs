

namespace FindMaxNumber;


internal class GenericMax<T> where T:IComparable
{
    public T[] value;
    public GenericMax(T[] value)
    {
        this.value = value;
    }

    public T[] Sort(T[] values)
    {
        Array.Sort(values);
        return values;
    }

    void add(params int[] a)
    {

    }

    public T MaxValue(params T[] values)
    {
        var sorted_values = Sort(values);

        return sorted_values[sorted_values.Length - 1];
    }

    public T MaxMethod()
    {
        var max = MaxValue(this.value);
        return max;
    }

    public void PrintMaxValue()
    {
        var max = MaxValue(this.value);
        Console.WriteLine("Maximum value is " + max);
    }
}