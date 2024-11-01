using Lombok.NET;

namespace Tag1_03Flyweight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo demo = new Demo();
            demo.X = 10;
            Console.WriteLine("Hello, World!");

            var person = new Person("Steve", 22);
            person = person.WithName("Collin");

            Console.WriteLine(person.Name); // Prints "Collin"
        }
    }

    //[AllArgsConstructor]
    [With]
    partial class Demo
    {
        [Property]
        private int _x;
        [Property]
        private int _y;
        private string _name;
        private int _age;
    }

    [AllArgsConstructor]
    [With]
    public partial class Person
    {
        [Property]
        private string _name;
        private int _age;
    }

}

