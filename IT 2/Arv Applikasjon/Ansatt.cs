
namespace Arv_Applikasjon
{
    internal class Ansatt
    {
        public static List<Ansatt> AlleAnsatte { get; } = new List<Ansatt>();

        public string Name { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }

        public Ansatt(string name, int age, int id, string title)
        {
            Name = name;
            Age = age;
            Id = id;
            Title = title;

            AlleAnsatte.Add(this);
        }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                   $"Age {Age}\n" +
                   $"Id: {Id}\n" +
                   $"Title: {Title}";
        }
    }
}
