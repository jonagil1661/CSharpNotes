using System;

namespace OOPNotes {
    class Car { // classes start with uppercase
        public string color = "red";
        public static bool electric = false;
        public static void Main(string[] args) {
            Car myObj = new Car();
            Console.WriteLine(myObj.color);

            Car sedan = new Car(); // multiple objects can be created in a class
            sedan.color = "black";
            Car suv = new Car();
            suv.color = "blue";

            Volvo safeCar = new Volvo(model: "XC60"); // object that can access another class. No import needed
            Console.WriteLine(safeCar.safetyFeature); 
            Console.WriteLine(safeCar.ReturnModel()); // returns value of private variable
        }
    }

    
}