namespace multithreading_concurrency;
/*

class Program
{
    static void Main()
    {
        Thread thread1 = new Thread(PrintNumbers);
        Thread thread2 = new Thread(PrintNumbers);

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();

        Console.WriteLine("Both threads have completed.");
    }

    static void PrintNumbers()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}: {i}");
            Thread.Sleep(2000); // Simulate some work
        }
    }
}

// In this example:

// Two threads (thread1 and thread2) are created and started.
// Each thread runs the PrintNumbers method, which prints numbers from 1 to 5.
// Thread.Sleep(1000) pauses the thread for 1 second to simulate work.
// thread1.Join() and thread2.Join() ensure that the main thread waits for both threads to complete before printing the final message.
*/

/*
//Using the Task Class
//The Task class in C# provides a higher-level abstraction for working with threads. Here’s an example using Task:

class Program
{
    static async Task Main()
    {
        Task task1 = Task.Run(() => PrintNumbers());
        Task task2 = Task.Run(() => PrintNumbers());

        await Task.WhenAll(task1, task2);

        Console.WriteLine("Both tasks have completed.");
    }

    static void PrintNumbers()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"{Task.CurrentId}: {i}");
            Task.Delay(2000).Wait(); // Simulate some work
        }
    }
}

// In this example:

// Task.Run is used to start the tasks.
// await Task.WhenAll(task1, task2) waits for both tasks to complete.
// Task.Delay(1000).Wait() pauses the task for 1 second to simulate work.

*/