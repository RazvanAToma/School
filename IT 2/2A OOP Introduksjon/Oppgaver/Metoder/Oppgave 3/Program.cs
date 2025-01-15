
using Oppgave_3;

Planet earth = new Planet("Earth", 150f, 6371f);
Planet mars = new Planet("Mars", 227.9f, 3389.5f);
Planet jupiter = new Planet("Jupiter", 778.5f, 69911f);

Console.WriteLine(jupiter.TravelTime());