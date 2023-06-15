namespace ClassDog;
public class Program
{
    public class Dog
    {
        public string name { get; set; } = string.Empty;
        public int age { get; set; } = 0;
        Colors color { get; set; } = Colors.None;
        public Dog(string Name, int Age, Colors Color)
        {
            name = Name;
            age = Age;
            color = Color;
        }
        public Dog() { }
        public void MakeSound()
        {
            Console.WriteLine("Gaf!!! Gaf!!!");
        }
        public void Call()
        {
            Console.WriteLine($"{name} come here !");
        }
        
    }
        
    public static void Main(string[] args)
    {
        Dog mydog = new Dog("Balu", 4, Colors.Yellow);
        mydog.MakeSound();
        mydog.Call();
    }
    public enum Colors
    {
        None,
        Yellow,
        Black,
        White
    }
}