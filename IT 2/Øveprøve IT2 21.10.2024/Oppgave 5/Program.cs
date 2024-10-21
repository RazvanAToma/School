
// Oppgave 5

int penger(int tikroner, int femkroner, int kronestykker)
{
    int sum = tikroner * 10 + femkroner * 5 + kronestykker;

    return sum;
}

Console.WriteLine(penger(2, 3, 3));