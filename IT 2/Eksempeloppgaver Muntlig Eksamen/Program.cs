
// Øving 1: Lister

/*

List<int> myList = new List<int> { 1, 2, 3, 4, 5 };

// a)
foreach (int num in myList)
{
    Console.WriteLine(num);
}

Console.WriteLine("\n\n");

// b)
foreach (int num in myList)
{
    Console.WriteLine(Math.Pow(num, 2));
}

Console.WriteLine("\n\n");

// c)
double sum = 0;
foreach (int num in myList)
{
    sum += num;
}
Console.WriteLine(sum / myList.Count);

Console.WriteLine("\n\n");

// d)
myList.Sort((a, b) => a.CompareTo(b));

int index = myList.Count - 2;

Console.WriteLine(myList[index]);

Console.WriteLine("\n\n");

// e)
int count = 0;
foreach (int num in myList)
{
    if (num > 10)
    {
        count += 1;
    }
}

Console.WriteLine(count);

*/


// Øving 2: Dictionary

/*

Dictionary<string, int> myDictionary = new Dictionary<string, int>();

// a)
myDictionary.Add("Alex", 14);
myDictionary.Add("Hanna", 19);
myDictionary.Add("Razvan", 18);
myDictionary.Add("Salar", 12);
myDictionary.Add("Sivert", 29);

Console.WriteLine(myDictionary["Sivert"]);

Console.WriteLine("\n\n");

// c)
string maxPerson = "";
int maxAge = 0;


foreach (KeyValuePair<string, int> pair in myDictionary)
{
    if (pair.Value > maxAge)
    {
        maxPerson = pair.Key;
        maxAge = pair.Value;
    }
}

Console.WriteLine(maxPerson, maxAge);

Console.WriteLine("\n\n");

// d)
foreach (KeyValuePair<string, int> pair in myDictionary)
{
    Console.WriteLine($"{pair.Key}, {pair.Value}");
}

Console.WriteLine("\n\n");

// e)
foreach (KeyValuePair<string, int> pair in myDictionary)
{
    myDictionary[pair.Key] += 1;
}

foreach (KeyValuePair<string, int> pair in myDictionary)
{
    Console.WriteLine($"{pair.Key}, {pair.Value}");
}

*/


// Øving 3: Pseudokode

/*

for (int i = 0; i < 100; i += 1)
{
    if (i % 4 == 0)
    {
        Console.WriteLine($"{i} er delelig med 4");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine($"{i} er delelig med 5");
    }
}

*/

// Øving 4: Algoritme

/*

int counter = 0;

for (int i = 10; i < 50; i += 1)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
        counter += 1;
    }
}

Console.WriteLine($"{counter} partall");

*/


// Øving 5: Operatorer

/*

int a = 10;
int b = 5;
int c = 2;

Console.WriteLine(((a + b) * c) / b);

double da = (double)a;

Console.WriteLine(((da + b) * c) / b);

*/


// Øving 6: Funksjoner og operatorer

/*

double BinomiskKvadrat(double a, double b)
{
    return Math.Pow(a, 2) + 2 * a * b + Math.Pow(b, 2);
}

Console.WriteLine(BinomiskKvadrat(2, 4));

*/

// Øving 7: Funksjoner og operatorer

/*

int Sum(int start, int end)
{
    int sum = 0;

    for (int i = start; i < end + 1; i += 1)
    {
        sum += i;
    }

    return sum;
}

Console.WriteLine(Sum(5, 50));  

*/

// Øving 8: If-setninger og logikk

/*

using Eksempeloppgaver_Muntlig_Eksamen;

Øving_8_if_setninger_og_logikk num = new Øving_8_if_setninger_og_logikk(-5);

Console.WriteLine(num.Value());

*/

// Øving 9: Klassen Elev

using Eksempeloppgaver_Muntlig_Eksamen;

Øving_9_Klassen_Elev elev1 = new Øving_9_Klassen_Elev("Razvan", "Toma", 6);

Console.WriteLine(elev1.ToString());