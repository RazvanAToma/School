using System;

public class Planet
{
	// Navnet til Planeten
	public string navn;

	// Avstand fra planeten til sola
	public float solavstand;

	// Planetens radius
	public float radius;

    public Planet(string navn, float solavstand, float radius)
    {
        this.navn = navn;
        this.solavstand = solavstand;
        this.radius = radius;
    }
}
