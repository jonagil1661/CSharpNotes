using System;

namespace Notes {
    class Animal {
        private bool mammal;

        public Animal(bool mammal) {
            this.mammal = mammal;
        }

        public bool GetMammal() {
            return this.mammal;
        }
        
    }
    class Dog : Animal { // child class Dog inherits from parent class Animal
        private string breed;
        public Dog(bool mammal, string breed) : base(mammal) { // use base() to call constructor in base class
            this.breed = breed;
        }

        public string GetBreed() {
            return this.breed;
        }
    }

    class Program {
        public static void Main(string[] args) {
            Dog dawg = new Dog(mammal: true, breed: "Golden Retriever");
            Console.WriteLine("It is a mammal: " + dawg.GetMammal());
            Console.WriteLine("It is a breed of " + dawg.GetBreed());
        }
    }
}