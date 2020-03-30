using System;

namespace _Interface
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Home!");
            Console.WriteLine();
            Console.ReadKey();

            Dog dog = new Dog("Jacob",25);
            dog.Voice();
            dog.GetInfo();
            Console.WriteLine();
            Console.ReadKey();

            Cat cat = new Cat("Pushok", 84);
            cat.Voice();
            cat.GetInfo();
            Console.WriteLine();
            Console.ReadKey();

            Parrot parrot = new Parrot("Mihalich", 2);
            parrot.Voice();
            parrot.GetInfo();
            Console.WriteLine();
            Console.ReadKey();

            Bird bird = new Bird("Konoreyca", 3);
            bird.Voice();
            bird.GetInfo();
            Console.WriteLine();
            Console.ReadKey();



        }
    }


    interface IAnimal
    {
        string Name { get; set; }
        string _Voice { get; }
        int Age { get; }

        void Voice()
        {
           
            Console.WriteLine(_Voice);
        }
        void GetInfo()
        {
            Console.WriteLine(Name, Age);
        }
    }
    
    
    class Dog:IAnimal
    {
        public string Name { get; set; }
        public string _Voice { get; }
        public int Age { get; }

        public Dog(string name, int age)
        {
            Name = name;
            _Voice = "Gav";
            Age = age;
            
        }
        
        public void Voice()
        {
            Console.WriteLine(_Voice);
        }
        public void GetInfo()
        {
            Console.WriteLine("Dog: " + Name + " " + Age);
        }
    }
    class Cat : IAnimal
    {
        public string Name { get; set; }
        public string _Voice { get; }
        public int Age { get; }

        public Cat(string name, int age)
        {
            Name = name;
            _Voice = "Meow";
            Age = age;
        }
        public void Voice()
        {
            Console.WriteLine(_Voice);
        }
        public void GetInfo()
        {
            Console.WriteLine("Cat: " + Name + " " + Age + " ");
        }

    }
    class Parrot:IAnimal
    {
        public string Name { get; set; }
        public string _Voice { get; }
        public int Age { get; }
        public Parrot(string name, int age)
        {
            Name = name;
            _Voice = "Gav Meow Twit";
            Age = age;
        }
        public void Voice()
        {
            Console.WriteLine(_Voice);
        }
        public void GetInfo()
        {
            Console.WriteLine("Parrot: " + Name + " " + Age);
        }

    }

    class Bird : IAnimal
    {
        public string Name { get; set; }
        public string _Voice { get; }
        public int Age { get; }
        public Bird (string name, int age)
        {
            Name = name;
            _Voice = "Twit";
            Age = age;
        }
        public void Voice()
        {
            Console.WriteLine(_Voice);
        }
        public void GetInfo()
        {
            Console.WriteLine("Bird: " + Name + " " + Age);
        }

    }
}
