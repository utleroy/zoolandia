using System;

namespace Zoolandia.Animals
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var Dog = new Animal();
            Dog.Type = "Golden Doodle";
            Dog.Color = "Brown";
            Dog.Name = "John Jacob";
            Dog.SignatureNoise = "Bark";
            Dog.Size = "large";

            var Cat = new Wild();
            Cat.Type = "Calico";
            Cat.Color = "Grey";
            Cat.Name = "Charlie";
            Cat.SignatureNoise = "Meow";
            Cat.Size = "small";

            Console.WriteLine($"I have a {Dog.Size} {Dog.Type} dog named {Dog.Name}. He can {Dog.SignatureNoise} on command. He is {Dog.Color}. I also have a {Cat.Size} {Cat.Type} cat named {Cat.Name}. She will only {Cat.SignatureNoise} when she's hungry. She is {Cat.Color}.");

            Dog.BrandOfFood();
            Cat.BrandOfFood();
        }
    }
}
