namespace exceptionhandling;

class Program
{
    static void Main(string[] args)
    {
       /* //Basic Try-Catch
      try
        {
            int[] numbers = { 1, 2, 3 };
            Console.WriteLine(numbers[5]); // This will throw an IndexOutOfRangeException
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("An exception occurred: " + ex.Message);
        }
        */

        /*
        //Try-Catch-Finally
            StreamReader reader = null;
        try
        {
            reader = new StreamReader("file1.txt");
            Console.WriteLine(reader.ReadToEnd());
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("File not found: " + ex.Message);
        }
        finally
        {
            if (reader != null)
            {
                reader.Close();
                Console.WriteLine("File stream closed.");
            }
        }
        */

        /*
        //Custom exception
        try
        {
            throw new CustomException("This is a custom exception.");
        }
        catch (CustomException ex)
        {
            Console.WriteLine("Caught custom exception: " + ex.Message);
        }
        */
        //Multiple Catch Blocks. You can have multiple catch blocks to handle different types of exceptions.

        try
        {
            int x = int.Parse("NotAnInt"); // This will throw a FormatException
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Format exception: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("General exception: " + ex.Message);
        }
    }
}


public class CustomException : Exception
{
    public CustomException(string message) : base(message) { }
}

//https://github.com/ziggyrafiq/csharp-exception-handling-guide/tree/main