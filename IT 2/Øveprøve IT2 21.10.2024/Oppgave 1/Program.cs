
// Oppgave 1

int kaffe = 20;
int vaffel = 30;

Console.Write("Hvor mange kaffe: ");
int antallKaffe = int.Parse(Console.ReadLine());

Console.Write("Hvor mange vaffel: ");
int antallVaffel = int.Parse(Console.ReadLine());

Console.WriteLine($"For {antallKaffe} kaffe, og {antallVaffel} vaffel, blir det {antallVaffel*vaffel + antallKaffe*kaffe} kroner");