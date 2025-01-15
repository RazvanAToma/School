using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave_5
{
    internal class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string JobTitle { get; set; }

        public Person(string name, int id, string jobTitle)
        {
            Name = name;
            Id = id;
            JobTitle = jobTitle;
        }


        public string Info()
        {
            return $"Navn: {Name}, Id: {Id}\nJobb: {JobTitle}";
        }
    }
}
