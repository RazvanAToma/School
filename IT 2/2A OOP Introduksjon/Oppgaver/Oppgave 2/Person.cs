using System;

public class Person
{
	// Fornavn
	public string fornavn;

	// Etternavn
	public string etternavn;

	// Fodselsaar
	public int fodselsaar;

    public Person(string fornavn, string etternavn, int fodselsaar)
    {
        this.fornavn = fornavn;
        this.etternavn = etternavn;
        this.fodselsaar = fodselsaar;
    }
}
