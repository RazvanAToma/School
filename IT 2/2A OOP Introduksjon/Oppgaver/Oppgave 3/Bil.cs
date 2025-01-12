using System;

public class Bil
{
    // Merke
    public string Merke;

    // Modell
    public string Modell;

    // Aarsmodell
    public int Aarsmodell;

    // Km-stand
    public double Kilometerstand;

    public Bil(string merke, string modell, int aarsmodell, double kilometerstand)
    {
        Merke = merke;
        Modell = modell;
        Aarsmodell = aarsmodell;
        Kilometerstand = kilometerstand;
    }
}
