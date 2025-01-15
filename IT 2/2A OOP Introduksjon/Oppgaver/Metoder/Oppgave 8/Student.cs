using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave_8
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Field { get; set; }

        public Student(string name, int age, string field)
        {
            Name = name;
            Age = age;
            Field = field;
        }

        public void Info()
        {
            Console.WriteLine($"Denne studenten heter {Name}, er {Age} år gammel, og studerer {Field}");
        }
    }
}
