namespace linq;
/*
class Program
{
    static void Main(string[] args)
    {
        //char
        //int
        //string

        char[] alphabets = new char[] {'a','b','c','e','f','h','i','u','s','v','z'};
        var resultaphabets = from x in alphabets
                            where x== 'a' || x=='e' || x== 'i' || x=='o' ||x=='u'
                            select x;
        foreach(var result in resultaphabets)
        {
            Console.WriteLine(result);
        }
        //Console.ReadLine();

        Console.WriteLine("***********************");

        int[] numbers = new int[] {2,4,7,8,13,17, 24,42,51,100};
        var resultNumers= from x in numbers
                        where x%2==0
                        select x;
        foreach (var item in resultNumers)
        {
            
            Console.WriteLine(item);
        }

        Console.WriteLine("***********************");
        
        string[] cities = new string[]{"Bengaluru","Chennai","Delhi","Hyderabad","Kochi","Bhopal","Leh"};

        var resultCities = from x in cities
                            where x.Length>5
                            orderby x
                            select x;
        foreach (var item in resultCities)
        {
            Console.WriteLine(item);
        }
    }
}
*/

class Program
    {
        static void Main(string[] args)
        {
            // Sample data
            List<Person> people = new List<Person>
            {
                new Person { Name = "Alice", Age = 30 },
                new Person { Name = "Bob", Age = 25 },
                new Person { Name = "Charlie", Age = 35 },
                new Person { Name = "David", Age = 28 }
            };

            // LINQ query to filter and sort the list
            var filteredAndSortedPeople = from person in people
                                          where person.Age > 25
                                          orderby person.Age
                                          select person;

            // Display the results
            Console.WriteLine("People older than 25, sorted by age:");
            foreach (var person in filteredAndSortedPeople)
            {
                Console.WriteLine($"{person.Name}, Age: {person.Age}");
            }
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }


//https://github.com/erjan123/101-LINQ-Samples/tree/master