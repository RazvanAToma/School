
using System.Text.Json;

string file = File.ReadAllText("C://Users//razva//Documents//GitHub//School//IT 2//3B Å jobbe med ekte datasett//Filbehandling Json//files/employees.json");

List<Employee> employees = JsonSerializer.Deserialize<List<Employee>>(file);

Employee.SalarySort(employees);

Employee.ShowAll(employees);