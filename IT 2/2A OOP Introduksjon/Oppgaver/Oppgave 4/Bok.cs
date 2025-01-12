using System;

public class Bok
{
    public string Tittel;
    public string Forfatter;
    public string ISBN;
    public int AntallSider;

    public Bok(string tittel, string forfatter, string iSBN, int antallSider)
    {
        Tittel = tittel;
        Forfatter = forfatter;
        ISBN = iSBN;
        AntallSider = antallSider;
    }
}
