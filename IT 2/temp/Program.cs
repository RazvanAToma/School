


double sum = 0;

int n = 12;

for (int i = 1; i < n + 1; i += 1)
{
    sum += 10000 * Math.Pow(1.03, i-1);
}

Console.WriteLine(sum);