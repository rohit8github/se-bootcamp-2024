namespace _04_Fundamentals;
/*
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}*/
//*******Work with Variable Data in C# Console Applications***********

//01-Choose the correct data type in your C# code
/*
//Discover value types and reference types
//https://learn.microsoft.com/en-us/training/modules/csharp-choose-data-type/2-value-reference-types 
*/

/*
//Discover integral types
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Signed integral types:");

        Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
        Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
        Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
        Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");
        
        Console.WriteLine("");
        Console.WriteLine("Unsigned integral types:");

        Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
        Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
        Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
        Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");
    }
}
*/

/*
//Discover floating-point types
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine("Floating point types:");
        Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
        Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
        Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
    }
}
*/

/*
//Discover reference types
class Program
{
    static void Main()
    {
        //Code1
        int val_A = 2;
        int val_B = val_A;
        val_B = 5;

        Console.WriteLine("--Value Types--");
        Console.WriteLine($"val_A: {val_A}");
        Console.WriteLine($"val_B: {val_B}");

        //Code2
        int[] ref_A= new int[1];
        ref_A[0] = 2;
        int[] ref_B = ref_A;
        ref_B[0] = 5;

        Console.WriteLine("--Reference Types--");
        Console.WriteLine($"ref_A[0]: {ref_A[0]}");
        Console.WriteLine($"ref_B[0]: {ref_B[0]}");
    }
}

// When ref_B = ref_A is executed, ref_B points to the same memory location as ref_A. So, when ref_B[0] is changed, ref_A[0] also changes because they both point to the same memory location. 
// This is a key difference between value types and reference types.
*/

//Choose the right data type
//https://learn.microsoft.com/en-us/training/modules/csharp-choose-data-type/6-choose-right-data-type 

//02-Convert data types using casting and conversion techniques in C#

/*
//Explore data type casting and conversion

class Program
{
    static void Main(string[] args)
    {
        //code1
        decimal myDecimal = 3.14m;
        Console.WriteLine($"decimal: {myDecimal}");

        int myInt = (int)myDecimal;
        Console.WriteLine($"int: {myInt}");

        //code2
        int first = 5;
        int second = 7;
        string message = first.ToString() + second.ToString();
        Console.WriteLine(message);

        //code3
        string first1 = "5";
        string second1 = "7";
        int sum = int.Parse(first1) + int.Parse(second1);
        Console.WriteLine(sum);

        //code4
        string value1 = "5";
        string value2 = "7";
        int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
        Console.WriteLine(result);
    }
}
*/

/*
//Examine the TryParse() method
class Program
{
    static void Main(string[] args)
    {
        //code1
        // string name = "Bob";
        // Console.WriteLine(int.Parse(name));

        //code2
        string value = "102";
        int result = 0;
        if (int.TryParse(value, out result))
        {
        Console.WriteLine($"Measurement: {result}");
        }
        else
        {
        Console.WriteLine("Unable to report the measurement.");
        }
        Console.WriteLine($"Measurement (w/ offset): {50 + result}");

        //code3
        string value1 = "bad";
        int result1 = 0;
        if (int.TryParse(value1, out result1))
        {
        Console.WriteLine($"Measurement: {result1}");
        }
        else
        {
        Console.WriteLine("Unable to report the measurement.");
        }

        if (result1 > 0)
        Console.WriteLine($"Measurement (w/ offset): {50 + result1}");
    }
}
*/

//03- Perform operations on arrays using helper methods in C#

/*
//Discover Sort() and Reverse()
class Program
{
    static void Main(string[] args)
    {

        //Sort & Reverse
        string[] pallets = { "B14", "A11", "B12", "A13" };

        Console.WriteLine("Sorted...");
        Array.Sort(pallets);
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }

        Console.WriteLine("");
        Console.WriteLine("Reversed...");
        Array.Reverse(pallets);
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }
    }
}
*/

/*
//Explore Clear() and Resize()
class Program
{
    static void Main(string[] args)
    {
        string[] pallets = { "B14", "A11", "B12", "A13" };
        Console.WriteLine("");

        Array.Clear(pallets, 0, 2);
        Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }

        Console.WriteLine("");
        Array.Resize(ref pallets, 6);
        Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

        pallets[4] = "C01";
        pallets[5] = "C02";

        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }

        Console.WriteLine("");
        Array.Resize(ref pallets, 3);
        Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }
    }
}
*/

/*
//Discover Split() and Join()
class Program
{
    static void Main(string[] args)
    {
        string value = "abc123";
        char[] valueArray = value.ToCharArray();
        Array.Reverse(valueArray);
        // string result = new string(valueArray);
        string result = String.Join(",", valueArray);
        Console.WriteLine(result);

        string[] items = result.Split(',');
        foreach (string item in items)
        {
            Console.WriteLine(item);
        }
    }
}
*/

//04-Modify the content of strings using built-in string data type methods in C#
/*
//Use the string's IndexOf() and Substring() helper methods
class Program
{
    static void Main(string[] args)
    {
       string message = "What is the value <span>between the tags</span>?";

        const string openSpan = "<span>";
        const string closeSpan = "</span>";

        int openingPosition = message.IndexOf(openSpan);
        int closingPosition = message.IndexOf(closeSpan);

        openingPosition += openSpan.Length;
        int length = closingPosition - openingPosition;
        Console.WriteLine(message.Substring(openingPosition, length));
    }
}
*/

/*
//Use the string's IndexOf() and LastIndexOf() helper methods

class Program
{
    static void Main(string[] args)
    {
        string message = "(What if) I am (only interested) in the last (set of parentheses)?";
        int openingPosition = message.LastIndexOf('(');

        openingPosition += 1;
        int closingPosition = message.LastIndexOf(')');
        int length = closingPosition - openingPosition;
        Console.WriteLine(message.Substring(openingPosition, length));
    }
}*/

/*
//Use the Remove() and Replace() methods
class Program
{
    static void Main(string[] args)
    {
        //code1
        string data = "12345John Smith          5000  3  ";
        string updatedData = data.Remove(5, 20);
        Console.WriteLine(updatedData);

        //code2
        string message = "This--is--ex-amp-le--da-ta";
        message = message.Replace("--", " ");
        message = message.Replace("-", "");
        Console.WriteLine(message);
    }
}
*/