
class Car
{
    public string model;
    public int year;
    public string color;

    public void PrintCar()
    {
        // Print car details
        Console.WriteLine($"Model: {model}, Year: {year}, Color: {color}");
    }
}

class MyGarage
{
    static void Main(string[] args)
    {
        // Create Ford car object
        Car Ford = new Car();
        Ford.model = "Explorer";
        Ford.year = 2022;
        Ford.color = "Black";

        // Create Opel1 car object
        Car Opel1 = new Car();
        Opel1.model = "Zafira";
        Opel1.year = 2010;
        Opel1.color = "Silver";

        // Create Opel2 car object
        Car Opel2 = new Car();
        Opel2.model = "Astra";
        Opel2.year = 2013;
        Opel2.color = "Gray";

        // Create Nissan car object
        Car Nissan = new Car();
        Nissan.model = "Qashqai";
        Nissan.year = 2024;
        Nissan.color = "White";

        // Print details of all cars
        Ford.PrintCar();
        Opel1.PrintCar();
        Opel2.PrintCar();
        Nissan.PrintCar();
    }
}
