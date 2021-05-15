using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interfaces!");

            Dogs dog = new Dogs();
            dog.Rollover();
            dog.SayHi();
            dog.Run();
        }
    }

    interface IAnimals
    {
        void Run();
    }
    interface IDogCommands : IAnimals
    {
        void Stay();
        void Sit();
        void Rollover();

        string DogName
        {
            set;
            get;
        }
    }

    class Animals
    {
        string AnimalName;

        public void SayHi()
        {
            Console.WriteLine("Hi from the animal class");
        }
    }
    class Dogs : Animals, IDogCommands
    {
        private string DogBreed;

        public void Stay()
        {
            Console.WriteLine("Dog is Staying");
        }

        public void Sit()
        {
            Console.WriteLine("Dog is Sitting");
        }

        public void Rollover()
        {
            Console.WriteLine("Dog is Rolling Over");
        }

        public void Run()
        {
            Console.WriteLine("Animal is Running");
        }
        public string DogName { get; set; }
    }
}
