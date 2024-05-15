/*
May 15, 2024 -- Write Lines, Data Types, and Input
*/
using System;
using System.Net;
using System.Runtime.InteropServices; //If this is omitted, writing "System.Console.WriteLine()" will need to be used
namespace Notes { //Containter for classes & other namespaces

class Program { //Unlike Java, name of C# file doesn't have to match with class name.
    public static void Main(string[] args) {
        Console.WriteLine("Hello World!"); //Console is the class of the 'System' namespace
        Console.Write("This doesn't skip a line.");

        //Arithmetic Operations can be done too.
        Console.WriteLine(1 + 1 + 2);

        /*
        Comment
        Multi-line
        */

        int a = 1; // integer
        double b = 1.34; // floating decimal values
        char c = 'a'; // single characters
        string d = "Hello, World!"; // string is NOT capitalized
        bool e = true; // boolean

        int f; // variables can be declared w/o instantiating
        f = 1000;

        const int g = 13; // const makes variable unchangable

        int a1, b1, c1;
        a1 = b1 = c1 = 2;

        long longNum = 1000000000L; // store large numbers, value must end with 'L'
        float floatNum = 1.2F; // store floats, must end with 'F'
        double doubleNum = 3.235D; // store double, must end with 'D'

        //Receiving User Input
        Console.WriteLine("Enter Name: ");
        string name = Console.ReadLine(); // only accepts/returns string
        Console.WriteLine("Name is: " + name);

        Console.WriteLine("Enter age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Age is: " + age);

        /*
        Assignment Operators
        Math
        */
        int x = 0;
        x += 3; // x = x + 3
        x -= 3; // x = x - 3
        x *= 3;
        x /= 3;
        x %= 1;

        // Math in C#
        Console.WriteLine(Math.Max(5, 10)); // Finds highest value, answer is 10
        Console.WriteLine(Math.Min(5, 10)); // Finds min values, answer is 5
        Console.WriteLine(Math.Sqrt(64)); // square root
        Console.WriteLine(Math.Abs(-4)); // absolute value
        Console.WriteLine(Math.Round(3.9)); // rounds to nearest whole number, 4

        /*
        Strings
        */
        string text = "qwertyuiopasdfghjklzxcvbnm";
        Console.WriteLine(text.Length); // outputs length of string
        Console.WriteLine(text.ToUpper()); // converts string to all upper case
        Console.WriteLine(text.ToLower()); // converts string to all lower case

        string name1 = "Joe";
        Console.WriteLine($"My name is: {name1}"); //string interpolation
        
        string word = "Hello, World!";
        Console.WriteLine(word[0]); // prints 'H'
        Console.WriteLine(word.IndexOf("o")); // prints 4

        Console.WriteLine("I \"love\" tacos!"); // use escape characters to print quotations
        Console.WriteLine("I\nlove\ttacos!"); // \n skips line, \t tabs

        /*
        Boolean
        */
        int num1 = 3, num2 = 7;
        Console.WriteLine(num1 > num2); //prints False
        Console.WriteLine(num1 >= num1); //prints True
        Console.WriteLine(num1 != num1); //prints False

        /*
        If else
        */
        if (1 < 3) {
            Console.WriteLine("yes");
        } else if (2 == 2) {
            Console.WriteLine("yes to");
        } else {
            Console.WriteLine("no");
        }

        /*
        Switch Statements
        */
        int nummy = 3;
        switch (nummy) {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            default:
                break;
        }

        /*
        Loops
        */
        int i = 0;
        while (i != 4) { // while loop
            i++;
        }

        //To execute code before checking if condition is true...
        do {
            //code block
        } while (i < 5);


        for (int j = 0; j < 5; j++) { // for loop
            Console.Write(j);
        }

        string[] letters = {"a", "b", "c"}; // foreach loop
        foreach (string j in letters) {
            Console.WriteLine(j);
        }

        /*
        Arrays
        */
        string[] strArray = {"hi", "hello"};
        int[] numArray = {1, 2, 3};
        
        Console.WriteLine(numArray[1]); // prints 2

        numArray[2] = 4; // changes index position 2 to value 4

        Console.WriteLine(strArray.Length); // prints length of array

        string[] declrArray = new string[5]; // declaring array size w/o info

        string[] cars;
        cars = new string[] {"Volvo", "Honda", "Ford"}; //add values to existing array

        for (int j = 0; j < cars.Length; j++) { //traverses through each element in array
            Console.WriteLine(cars[j]);
        }

        Array.Sort(cars); // sorts in alphanumerical order

        /*
        you can use 'using System.Linq' to access other array methods
        numArray.Max(), numArray.Min(), numArray.Sum()
        */
    }
}
}