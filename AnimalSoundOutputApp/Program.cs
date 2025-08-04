using System;

class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal genericAnimal = new Animal();
        Animal dog = new Dog();
        Animal cat = new Cat();

        Console.WriteLine("=== Animal Sounds ===");
        genericAnimal.MakeSound();  // Outputs: Some generic sound
        dog.MakeSound();            // Outputs: Bark
        cat.MakeSound();            // Outputs: Meow
    }
}
