namespace _01_Fundamentals;

//******Write Your First Code Using C#******
/*
//01-Write your first code

Console.WriteLine("Hello, World!");
console.WriteLine("Hello World!");
Console.WriteLine('Hello World!');

Console.Write("Congratulations!");
Console.Write(" ");
Console.Write("You wrote your first lines of code.");

Console.WriteLine("Congratulations!");
Console.Write("You wrote your first lines of code.");
*/

/*

Learn how it works

What is a programming language?
What is compilation?
What is syntax?
How did your code work? 
    Literal String, Class, Method, Method Invokation Operator(), End of statement operator ;, Syntax

*/

/*
//Knowledge Check

1. What is the primary job of the compiler? 

    The compiler primarily locates spelling mistakes in your code.

    The compiler primarily executes your code.

    The compiler primarily converts your code into an executable format that the computer can understand.

2. Which of the following statements is true about C#? 

    C# is case insensitive.

    Console is a method, and WriteLine() is a class.

    You use double quotation marks to create a literal string.

3. What is wrong with this line of code? Console.WriteLine("What is wrong with me?") 

    The L in WriteLine should be lower-case.

    It's missing a semi-colon at the end

    The string should use single-quotes.
*/

//02- Store and retrieve data using literal and variable values in C#
/*
Console.WriteLine('b');
Console.WriteLine('Hello World!');
Console.WriteLine(123);

//Float Type    Precision
//----------------------------
//float         ~6-9 digits
//double        ~15-17 digits
//decimal        28-29 digits

Console.WriteLine(true);
Console.WriteLine(false);

The main takeaway is that there are many data types, but you'll focus on just a few for now:

string for words, phrases, or any alphanumeric data for presentation, not calculation
char for a single alphanumeric character
int for a whole number
decimal for a number with a fractional component
bool for a true/false value

*/
/*
//Declare variables
string firstName;
char userOption;
int gameScore;
decimal particlesPerMillion;
bool processedCustomer;

Variables are temporary values you store in the computer's memory.
Before you can use a variable, you have to declare it.
To declare a variable, you first select a data type for the kind of data you want to store, and then give the variable a name that follows the rules.
*/

/*
//Initialize & Retrieve variable
string firstName;
Console.WriteLine(firstName);

string firstName = "Bob";
Console.WriteLine(firstName);
*/

/*
string name = "Bob";
int messages = 3;
decimal temperature = 34.4m;

Console.Write("Hello, ");
Console.Write(name);
Console.Write("! You have ");
Console.Write(messages);
Console.Write(" messages in your inbox. The temperature is ");
Console.Write(temperature);
Console.Write(" celsius.");
*/

//03- Perform basic string formatting in C#

/*
\\Format literal strings in C#
Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");

Console.WriteLine("c:\source\repos");
Console.WriteLine("c:\\source\\repos");

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
*/

/*
//Combine strings using string concatenation
string firstName = "Bob";
string message = "Hello " + firstName;
Console.WriteLine(message);

string firstName = "Bob";
string greeting = "Hello";
string message = greeting + " " + firstName + "!";
Console.WriteLine(message);
*/

/*
//Combine strings using string interpolation
string firstName = "Bob";
string message = $"Hello {firstName}!";
Console.WriteLine(message);

int version = 11;
string updateText = "Update to Windows";
string message = $"{updateText} {version}";
Console.WriteLine(message);

string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");
*/

//03- Perform basic operations on numbers in C#

/*
//Perform addition with implicit data conversion
int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");

string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");

string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");
*/

/*
//Perform math operations

int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);

Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");
*/