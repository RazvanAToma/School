
namespace Arv_Applikasjon
{
    internal class SoftwareUtvikler : Ansatt
    {
        public int Projects { get; set; }

        public SoftwareUtvikler(string name, int age, int id, string title, int projects) : base(name, age, id, title)
        {
            Projects = projects;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nProjects: {Projects}\n";
        }
    }
}
