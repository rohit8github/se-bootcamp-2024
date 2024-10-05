namespace _03_Fundamentals;
//*************Add Logic to C# Console Applications*************


//01-Evaluate Boolean expressions to make decisions in C#
/*
//Evaluate an expression
class Program
{
    static void Main(string[] args)
    {
        string value1 = " a";
        string value2 = "A ";
        Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

        Console.WriteLine("a" != "a");
        Console.WriteLine("a" != "A");
        Console.WriteLine(1 != 2);

        string myValue = "a";
        Console.WriteLine(myValue != "a");
    }
}
*/
/*
//Implement the conditional operator
class Program
{
    static void Main(string[] args)
    {
        int saleAmount = 1001;
        // int discount = saleAmount > 1000 ? 100 : 50;

        Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
    }
}
*/

//02-Control variable scope and logic using code blocks in C#

/*
//Code blocks and variable scope
class Program
{
    static void Main(string[] args)
    {
        bool flag = true;
        int value=0;

        if (flag)
        {
            Console.WriteLine($"Inside the code block: {value}");
        }

        value = 10;
        Console.WriteLine($"Outside the code block: {value}");

        // Code sample 2
        int value1;

        if (true)
        {
            value1 = 10;
            Console.WriteLine($"Inside the code block: {value1}");
        }

        Console.WriteLine($"Outside the code block: {value1}");
    }
}
*/

/*
//Remove code blocks from if statements

class Program
{
    static void Main(string[] args)
    {
        //code1
        bool flag = true;
        if (flag)
        {
            Console.WriteLine(flag);
        }

        //code2
        bool flag1 = true;
        if (flag1)
            Console.WriteLine(flag1);

        //Code3
       string name = "steve";

        if (name == "bob")
            Console.WriteLine("Found Bob");
        else if (name == "steve") 
            Console.WriteLine("Found Steve");
        else
            Console.WriteLine("Found Chuck");
    }
}
*/

//03- Branch the flow of code using the switch-case construct in C#

/*
//Implement a switch statement
class Program
{
    static void Main()
    {
        int employeeLevel = 200;
        string employeeName = "John Smith";

        string title = "";

        switch (employeeLevel)
        {
            case 100:
                title = "Associate Software Engineer";
                break;
            case 200:
                title = "Software Engineer";
                break;
            case 300:
                title = "Senior Software Engineer";
                break;
            case 400:
                title = "Principal Software Engineer";
                break;
            default:
                title = "Sr. Principal Software Engineer";
                break;
        }

        Console.WriteLine($"{employeeName}, {title}");
    }
}
*/

//04-Iterate through a code block using for statement in C#
/*
//Create and configure for iteration loops

class Program
{
    static void Main()
    {
        //Code1
        for (int i = 0; i < 10; i += 3)
        {
            Console.WriteLine(i);
        }
        //code2
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
            if (i == 7) break;
        }
        //code3
        string[] names = { "Alex", "Eddie", "David", "Michael" };
        foreach (var name in names)
        {
            // Can't do this:
            if (name == "David") name = "Sammy";
        }

        //code4
        string[] names1 = { "Alex", "Eddie", "David", "Michael" };
        for (int i = 0; i < names1.Length; i++)
            if (names1[i] == "David") names1[i] = "Sammy";

        foreach (var name in names1) Console.WriteLine(name);
    }
}
*/

//05-Add Looping Logic to Your Code Using the do-while and while Statements in C#
/*
//Create do and while iteration loops
class Program
{
    static void Main()
    {
        // do
        // {
        //     // This code executes at least one time
        // } while (true);

        Random random = new Random();
        int current = random.Next(1, 11);

        // do
        // {
        //     current = random.Next(1, 11);

        //     if (current >= 8) continue;

        //     Console.WriteLine(current);
        // } while (current != 7);

        
        while (current >= 3)
        {
            Console.WriteLine(current);
            current = random.Next(1, 11);
        }
        Console.WriteLine($"Last number: {current}");
        
    }
}
*/