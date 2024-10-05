namespace reflectionmetadata;

using System.Reflection;
/*
//Inspecting Types and Members
public class MyClass
{
    public int MyProperty { get; set; }
    public void MyMethod() { }
}

class Program
{
    static void Main()
    {
        Type type = typeof(MyClass);

        Console.WriteLine("Class: " + type.Name);

        Console.WriteLine("Properties:");
        foreach (PropertyInfo prop in type.GetProperties())
        {
            Console.WriteLine(" - " + prop.Name);
        }

        Console.WriteLine("Methods:");
        foreach (MethodInfo method in type.GetMethods())
        {
            Console.WriteLine(" - " + method.Name);
        }
    }
}
*/

//Dynamically Invoking Methods
/*
public class MyClass
{
    public void MyMethod()
    {
        Console.WriteLine("MyMethod invoked");
    }
}

class Program
{
    static void Main()
    {
        Type type = typeof(MyClass);
        object instance = Activator.CreateInstance(type);

        MethodInfo method = type.GetMethod("MyMethod");
        method.Invoke(instance, null);
    }
}
*/

//Accessing Private Members

public class MyClass
{
    private int myField = 42;
}

class Program
{
    static void Main()
    {
        Type type = typeof(MyClass);
        object instance = Activator.CreateInstance(type);

        FieldInfo field = type.GetField("myField", BindingFlags.NonPublic | BindingFlags.Instance);
        int fieldValue = (int)field.GetValue(instance);

        Console.WriteLine("Private field value: " + fieldValue);
    }
}
