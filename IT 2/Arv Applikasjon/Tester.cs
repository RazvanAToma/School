
namespace Arv_Applikasjon
{
    internal class Tester : Ansatt
    {
        public int Programs { get; set; }

        public Tester(string name, int age, int id, string title, int programs) : base(name, age, id, title)
        {
            Programs = programs;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nPrograms: {Programs}\n";
        }
    }
}
