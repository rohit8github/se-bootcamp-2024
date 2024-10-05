namespace asyncprogramming;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*
//synchronous example
using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        LongProcess();
        ShortProcess();
    }
    static void LongProcess()
    {
        Console.WriteLine("LongProcess Started");
        Thread.Sleep(4000); // Simulate a long-running task
        Console.WriteLine("LongProcess Completed");
    }
    static void ShortProcess()
    {
        Console.WriteLine("ShortProcess Started");
        Console.WriteLine("ShortProcess Completed");
    }
}
*/
/*
//Asynchronous example
using System;
using System.Threading.Tasks;
class Program
{
    static async Task Main(string[] args)
    {
        await LongProcess();
        ShortProcess();
    }
    static async Task LongProcess()
    {
        Console.WriteLine("LongProcess Started");
        await Task.Delay(10000); // Simulate a long-running task
        Console.WriteLine("Pls enter some text");
        Console.ReadLine();
        Console.WriteLine("LongProcess Completed");
    }
    static void ShortProcess()
    {
        Console.WriteLine("ShortProcess Started");
        Console.WriteLine("ShortProcess Completed");
    }
}
*/
class Program
{
    static void Main(string[] args)
    {
        Method1();
        Method2();
        Console.ReadLine();
    }
    //public static async Task Method1()
    public static void Method1()
    {
        // await Task.Run(()=>{
        //     for(int i=0; i<100; i++)
        //     {
        //         Console.WriteLine("Method1 is running");
        //         Task.Delay(100).Wait();
        //     }
        // });
         for(int i=0;i<100;i++)
        {
            Console.WriteLine("Method1 is running");
            Task.Delay(100).Wait();
        }
    }
    public static void Method2()
    {
        
        for(int i=0;i<25;i++)
        {
            Console.WriteLine("Method 2 is running");
            Task.Delay(100).Wait();
        }
    }
}
