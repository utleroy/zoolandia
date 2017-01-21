using System;

namespace Zoolandia.Animals
{
    public class Animal
    {
        public string Name { get; set; }
        public string Color { get; set;}
        public string SignatureNoise { get; set; }
        public string Size { get; set; }
        public string Type { get; set; }
        public virtual void BrandOfFood()
        {
            Console.WriteLine("Alpo");
        }
            
    }
    public class Wild : Animal
    {
        public override void BrandOfFood()
        {
            Console.WriteLine("Kitten Kabootles");
        }
    }
}