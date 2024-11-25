
int result = 0;
int prevResult = 1;


int[] digits = new int[4];
bool cont = true;

Console.Write("Skriv inn et firesifret tall, som har minst to ulike sifre: ");
string num = Console.ReadLine();

void Test(string input)
{
    if (input.Length == 4)
    {
        for (int i = 0; i < input.Length; i += 1)
        {
            digits[i] = int.Parse(input[i].ToString());
        }

        foreach (int i in digits)
        {
            if (digits[0] != i)
            {
                cont = false;
            }
        }
    }
}



int CalcResult()
{
    List<int> digitsInc = new List<int>(digits);
    digitsInc.Sort();

    List<int> digitsDec = new List<int>(digits);
    digitsDec.Sort();
    digitsDec.Reverse();

    int numberInc = int.Parse(string.Join("", digitsInc));
    int numberDec = int.Parse(string.Join("", digitsDec));

    result = numberDec - numberInc;
    Console.WriteLine($"{numberDec} - {numberInc} = {result}");

    string resultString = result.ToString("D4");
    for (int i = 0; i < resultString.Length; i++)
    {
        digits[i] = int.Parse(resultString[i].ToString());
    }

    return result;
}


while (cont)
{
    Test(num);
}

while (result != prevResult)
{
    prevResult = result;
    CalcResult();
}

Console.WriteLine($"Resultatet stabiliserer seg til: {result}");