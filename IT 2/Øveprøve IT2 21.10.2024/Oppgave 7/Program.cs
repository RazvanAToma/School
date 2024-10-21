
// Oppgave 7

Dictionary<string, int> testDict = new Dictionary<string, int> { { "test1", 2 }, { "test2", 5 }, { "test3", 7 }, { "test4", 2 } };


double calcAverage(Dictionary<string, int> dict)
{
    int sum = 0;

    int counter = 0;

    foreach (KeyValuePair<string, int> pair in testDict)
    {
        sum += pair.Value;
        counter += 1;
    }

    return sum / counter;
}

Console.WriteLine(calcAverage(testDict));