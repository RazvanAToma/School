
public class Ansatt
{
    public string Fornavn       {  get; set; }
    public string Etternavn     {  get; set; }
    public int    Alder         {  get; set; }
    public double TimerJobbet   {  get; set; }
    public string Stilling      {  get; set; }

    public Ansatt(string fornavn, string etternavn, int alder, double timerJobbet, string stilling)
    {
        Fornavn = fornavn;
        Etternavn = etternavn;
        Alder = alder;
        TimerJobbet = timerJobbet;
        Stilling = stilling;
    }
}
