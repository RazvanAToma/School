
// Oppgave 4

int funksjon(int n) // Funksjon som tar inn en int som parameter
{
    if (n <= 1) // sjekker hvis parameteren er lik eller mindre enn 1
    {
        return n; // hvis ja, returner parameter
    }
    else // ellers
    {
        return n + funksjon(n - 1); // ta parameteren og legg til hvert heltall mindre enn parameteren frem til tallet 1
    }
}