namespace memorymanagement;

/*
//Basic Garbage Collection
class Program
{
    static void Main()
    {
        CreateObjects();
        GC.Collect(); // Force garbage collection
        Console.WriteLine("Garbage Collection triggered.");
    }

    static void CreateObjects()
    {
        for (int i = 0; i < 1000; i++)
        {
            var obj = new object();
        }
    }
}
*/

/*
//Using Span<T> and Memory<T> Span<T> and Memory<T> are used for efficient memory management, especially when working with large arrays or buffers.
//In this example, stackalloc is used to allocate memory on the stack, while Memory<T> is used to handle memory on the heap

class Program
{
    static void Main()
    {
        Span<int> stackSpan = stackalloc int[3] { 1, 2, 3 };
        Memory<int> heapMemory = new int[] { 4, 5, 6 };

        Console.WriteLine("Stack Memory:");
        foreach (var item in stackSpan)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\nHeap Memory:");
        foreach (var item in heapMemory.Span)
        {
            Console.WriteLine(item);
        }
    }
}
*/

/*
//Object Pooling
//Object pooling is a technique to reuse objects instead of creating and destroying them frequently, which can help reduce GC overhead.

public class ObjectPool<T> where T : new()
{
    private readonly Stack<T> _objects = new Stack<T>();

    public T GetObject()
    {
        return _objects.Count > 0 ? _objects.Pop() : new T();
    }

    public void ReleaseObject(T obj)
    {
        _objects.Push(obj);
    }
}

class Program
{
    static void Main()
    {
        var pool = new ObjectPool<MyClass>();

        MyClass obj1 = pool.GetObject();
        pool.ReleaseObject(obj1);

        MyClass obj2 = pool.GetObject();
        Console.WriteLine(ReferenceEquals(obj1, obj2)); // True
    }
}

public class MyClass
{
    // Class implementation
}


//In this example, the ObjectPool<T> class manages a pool of reusable objects, reducing the need for frequent allocations and deallocations
*/


