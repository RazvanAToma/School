
// Create a Class

// Class named car, with a variable "color";
class Car
{
    string color = "red";
}



// Create an object

class NewCar
{
    string color = "red";

    static void Main(string[] args)
    {
        NewCar newCar = new NewCar();
        Console.WriteLine(newCar.color);
    }
}



// Creating multiple object for the same class

class MyCar
{
    string color = "black";

    static void Main(string[] args)
    {
        MyCar myObj1 = new MyCar();
        MyCar myObj2 = new MyCar();

        Console.WriteLine(myObj1.color);
        Console.WriteLine(myObj2.color);
    }
}