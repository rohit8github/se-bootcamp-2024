namespace _05_Fundamentals;
/*
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}*/

//*********Create Methods in C# Console Applications*********
/*
//01-Write your first C# method
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Before calling a method");
        SayHello();
        Console.WriteLine("After calling a method");

        void SayHello() 
        {
            Console.WriteLine("Hello World!");
        }
    }
}
//https://learn.microsoft.com/en-us/training/modules/write-first-c-sharp-method/2-understand-syntax-of-methods 
*/

/*
//Create your first method

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Generating random numbers:");
        DisplayRandomNumbers();

        void DisplayRandomNumbers() 
        {
            Random random = new Random();

            for (int i = 0; i < 5; i++) 
            {
                Console.Write($"{random.Next(1, 100)} ");
            }

            Console.WriteLine();
        }
    }
}
*/

/*
//Create reusable methods

class Program
{
    static void Main(string[] args)
    {
        int[] times = {800, 1200, 1600, 2000};
        int diff = 0;

        Console.WriteLine("Enter current GMT");
        int currentGMT = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Current Medicine Schedule:");
        DisplayTimes();

        Console.WriteLine("Enter new GMT");
        int newGMT = Convert.ToInt32(Console.ReadLine());

        if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
        {
            Console.WriteLine("Invalid GMT");
        }
        else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
        {
            diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
            AdjustTimes();
        } 
        else 
        {
            diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
            AdjustTimes();
        }

        Console.WriteLine("New Medicine Schedule:");
        DisplayTimes();

        void DisplayTimes()
        {
            // Format and display medicine times
            foreach (int val in times)
            {
                string time = val.ToString();
                int len = time.Length;

                if (len >= 3)
                {
                    time = time.Insert(len - 2, ":");
                }
                else if (len == 2)
                {
                    time = time.Insert(0, "0:");
                }
                else
                {
                    time = time.Insert(0, "0:0");
                }

                Console.Write($"{time} ");
            }
            Console.WriteLine();
        }

        void AdjustTimes() 
        {
            // Adjust the times by adding the difference, keeping the value within 24 hours 
            for (int i = 0; i < times.Length; i++) 
            {
                times[i] = ((times[i] + diff)) % 2400;
            }
        }
    }
}
*/

/*
//Build code with methods
class Program
{
    static void Main(string[] args)
    {
        string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
        string[] address;
        bool validLength = false;
        bool validZeroes = false;
        bool validRange = false;

        foreach (string ip in ipv4Input) 
        {
            address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

            ValidateLength(); 
            ValidateZeroes(); 
            ValidateRange();

            if (validLength && validZeroes && validRange) 
            {
                Console.WriteLine($"{ip} is a valid IPv4 address");
            } 
            else 
            {
                Console.WriteLine($"{ip} is an invalid IPv4 address");
            }
        }

        void ValidateLength() 
        {
            validLength = address.Length == 4;
        };

        void ValidateZeroes() 
        {
            foreach (string number in address) 
            {
                if (number.Length > 1 && number.StartsWith("0")) 
                {
                    validZeroes = false;
                    return;
                }
            }

            validZeroes = true;
        }

        void ValidateRange() 
        {
            foreach (string number in address) 
            {
                int value = int.Parse(number);
                if (value < 0 || value > 255) 
                {
                    validRange = false;
                    return;
                }
            }
            validRange = true;
        }
    }
}
*/


//02-Create C# Methods with Parameters
/*
//Use parameters in methods
class Program
{
    static void Main()
    {
        DisplayAdjustedTimes(schedule, 6, -6);
    }
    static int[] schedule = {800, 1200, 1600, 2000};
    static void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT) 
    {
        int diff = 0;
        if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
        {
            Console.WriteLine("Invalid GMT");
        }
        else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
        {
            diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
        } 
        else 
        {
            diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
        }

        for (int i = 0; i < times.Length; i++) 
        {
            int newTime = ((times[i] + diff)) % 2400;
            Console.WriteLine($"{times[i]} -> {newTime}");
        }

    }
}
*/
/*
//Understand method scope
class Program
{
    static void Main(string[] args)
    {
        PrintCircleInfo(12);
        PrintCircleInfo(24);
    }
   static double pi = 3.14159;
    static void PrintCircleInfo(int radius) 
    {
        Console.WriteLine($"Circle with radius {radius}");
        PrintCircleArea(radius);
        PrintCircleCircumference(radius);
    }
    static void PrintCircleArea(int radius)
    {
        double area = pi * (radius * radius);
        Console.WriteLine($"Area = {area}");
    }

    static void PrintCircleCircumference(int radius)
    {
        double circumference = 2 * pi * radius;
        Console.WriteLine($"Circumference = {circumference}");
    }
}
*/
/*
//Use value and reference type parameters
class Public
{
    static void Main()
    {
        //Code1
         int a = 3;
         int b = 4;
         int c = 0;

        Multiply(a, b, c);
        Console.WriteLine($"global statement: {a} x {b} = {c}");

        //Code2
         int[] array = {1, 2, 3, 4, 5};

        PrintArray(array);
        Clear(array);
        PrintArray(array);
    }

    static void Multiply(int a, int b, int c) 
    {
        c = a * b;
        Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
    }
    //Notice that the value of c is only altered within the Multiply method. Outside of the method, c retains its original value

    static void PrintArray(int[] array) 
    {
        foreach (int a in array) 
        {
            Console.Write($"{a} ");
        }
        Console.WriteLine();
    }

    static void Clear(int[] array) 
    {
        for (int i = 0; i < array.Length; i++) 
        {
            array[i] = 0;
        }
    }
    //Arrays are reference types. Reference types store the address of their values in memory. 
}
*/

//03-Create C# methods that return values
/*
//Understand return type syntax

class Program
{
    static double total = 0;
    static double minimumSpend = 30.00;
    static double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
    static double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};
    static void Main()
    {
        
        for (int i = 0; i < items.Length; i++)
        {
            total += GetDiscountedPrice(i);
        }

        total -= TotalMeetsMinimum() ? 5.00 : 0.00;

        Console.WriteLine($"Total: ${FormatDecimal(total)}");
    }

    static double GetDiscountedPrice(int itemIndex)
    {
        return items[itemIndex] * (1 - discounts[itemIndex]);
    }

    static bool TotalMeetsMinimum()
    {
        return total >= minimumSpend;
    }

    static string FormatDecimal(double input)
    {
        return input.ToString().Substring(0, 5);
    }
}
*/