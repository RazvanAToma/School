
Planet pluto = new Planet("Pluto", 5.9f, 1000);
Planet jorda = new Planet("Jorda", 0.147f, 6371);

Console.WriteLine($"{pluto.navn}, {pluto.solavstand}, {pluto.radius}");
Console.WriteLine($"{jorda.navn}, {jorda.solavstand}, {jorda.radius}");

Console.WriteLine(jorda.Volum());