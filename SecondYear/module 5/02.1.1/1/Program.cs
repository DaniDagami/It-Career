using System.Reflection;

namespace _1 {
    class Program {
        static void Main(string[] args) {
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);
            Person one = new Person() { name = "Finn", age = 18 };
            Person two = new Person() { name = "Jake", age = 18 };
            Console.WriteLine(one.name + one.age);
            Console.WriteLine(two.name + two.age);
        }
    }
}