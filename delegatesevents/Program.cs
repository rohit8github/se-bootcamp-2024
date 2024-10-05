namespace delegatesevents;

/*
//A delegate is a type that represents references to methods with a particular parameter list and return type.
public delegate void DisplayMessage(string message);

class Program
{
    static void Main()
    {
        DisplayMessage messageDelegate = ShowMessage;
        messageDelegate("Hello, World!");
    }

    static void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
}
*/

/*
//Events are a way for a class to notify other classes or objects when something of interest occurs. Events are based on delegates.
public class Publisher
{
    public delegate void Notify();  // delegate
    public event Notify OnPublish;  // event

    public void Publish()
    {
        Console.WriteLine("Publishing an event...");
        OnPublish?.Invoke();
    }
}

public class Subscriber
{
    public void Subscribe(Publisher publisher)
    {
        publisher.OnPublish += RespondToEvent;
    }

    void RespondToEvent()
    {
        Console.WriteLine("Event received and handled.");
    }
}

class Program
{
    static void Main()
    {
        Publisher publisher = new Publisher();
        Subscriber subscriber = new Subscriber();

        subscriber.Subscribe(publisher);
        publisher.Publish();
    }
}
//In this example, the Publisher class defines an event OnPublish based on the Notify delegate. The Subscriber class subscribes to this event and defines a method RespondToEvent that handles the event when it is triggered.

*/

class Program
{
    public delegate bool myDelegate(string s);

	public static bool IsDotnet(string name)
	{
		return name == "dotnet8";
	}
    static void Main()
    {
        // This is just to show the Func's equivalent delegate way of doing things, which is less code here,
		// but you end up repeating delegates everywhere.
		//
		// Syntax:
		// - method1. is C# 3.0
		// - method2. is C# 2.0
		// - method3. is C# 1.0
		// - method4. is C# 2.0+
		//
		myDelegate method1 = ((name) => name == "dotnet");
		myDelegate method2 = delegate(string name)
		{
			return name == "dotnet";
		};
		myDelegate method3 = new myDelegate(IsDotnet);
		myDelegate method4 = IsDotnet; // Shorthand for the above

		// bool isDotnet1 = method1("dotnet");
		// bool isDotnet2 = method2("dotnet6");
		// bool isDotnet3 = method3("dotnet7");
		// bool isDotnet4 = method4("dotnet8");

		Console.WriteLine(method1("dotnet"));
		Console.WriteLine(method2("dotnet6"));
		Console.WriteLine(method3("dotnet7"));
		Console.WriteLine(method4("dotnet8"));
    }
}