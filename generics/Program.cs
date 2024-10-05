namespace generics;

//Generics allow us to make Classes & Methods - type independent or type safe.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(CompareItems.AreEqual(5,6));
        Console.WriteLine(CompareItems.AreEqual("Five","Six"));

        Console.WriteLine(CompareItems.AreEqualGeneric<int>(5,6));
        Console.WriteLine(CompareItems.AreEqualGeneric<string>("Five", "six"));

        Console.WriteLine(GenericCompareItems<int>.AreEqual(5,6));
        Console.WriteLine(GenericCompareItems<string>.AreEqual("Five","Six"));
    }
}

public class CompareItems
{
    // public static bool AreEqual(int value1, int value2) //Type dependent
    // {
    //     return value1.Equals(value2);
    // }

    public static bool AreEqual(object value1, object value2)
    //The probem is, it involves Boxing from converting string(Value) to object(reference) type. This would impact the performance.
    {
        return value1.Equals(value2);
    }

    public static bool AreEqualGeneric<T>(T value1, T value2) //T is here short of Type, we can use iny char
    {
        return value1.Equals(value2);
    }

}

//Generic Class
public class GenericCompareItems<T>
{
    public static bool AreEqual(T value1, T value2)
    {
        return value1.Equals(value2);
    }
}