
using System.Text.Json;

string s = File.ReadAllText("employees.json");

List<Employee> employees = JsonSerializer.Deserialize<List<Employee>>(s);

Console.WriteLine(employees[0].firstName);
