using System;

namespace Zoolandia.Animals
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var Dog= new Animal();
            Dog.Color = "Black";
            Dog.Name = "Fido";
            Dog.SignatureNoise = "Bark";
            Dog.Size = "Large";

            Console.WriteLine($"I have a dog named {Dog.Name}. He can {Dog.SignatureNoise} on command.");
        }
    }
}
