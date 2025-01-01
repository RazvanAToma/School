public class Employee
{
    public string userId { get; set; }
    public string jobTitleName { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string preferredFullName { get; set; }
    public string employeeCode { get; set; }
    public string region { get; set; }
    public string phoneNumber { get; set; }
    public string emailAddress { get; set; }
    public int years_employed { get; set; }
    public int salary { get; set; }

    public Employee(string userId, string jobTitleName, string firstName, string lastName, string preferredFullName, string employeeCode, string region, string phoneNumber, string emailAddress, int years_employed, int salary)
    {
        this.userId = userId;
        this.jobTitleName = jobTitleName;
        this.firstName = firstName;
        this.lastName = lastName;
        this.preferredFullName = preferredFullName;
        this.employeeCode = employeeCode;
        this.region = region;
        this.phoneNumber = phoneNumber;
        this.emailAddress = emailAddress;
        this.years_employed = years_employed;
        this.salary = salary;
    }

    public static void YearSort(List<Employee> list)
    {
        list.Sort(delegate (Employee a, Employee b)
        {
            return a.years_employed.CompareTo(b.years_employed);
        });

        list.Reverse();
    }

    public static void SalarySort(List<Employee> list)
    {
        list.Sort(delegate (Employee a, Employee b)
        {
            return a.salary.CompareTo(b.salary);
        });

        list.Reverse();
    }

    public static void IdSort(List<Employee> list)
    {
        list.Sort(delegate (Employee a, Employee b)
        {
            return a.userId.CompareTo(b.userId);
        });
    }

    public static void CodeSort(List<Employee> list)
    {
        list.Sort(delegate (Employee a, Employee b)
        {
            return a.employeeCode.CompareTo(b.employeeCode);
        });
    }


    public static void ShowAll(List<Employee> list)
    {
        foreach (Employee employee in list)
        {
            Console.WriteLine($"{employee.firstName}, {employee.lastName}");
            Console.WriteLine($"User ID:\t{employee.userId}");
            Console.WriteLine($"Years Employed:\t{employee.years_employed}");
            Console.WriteLine($"Salary:\t\t{employee.salary}");

            Console.WriteLine("\n");
        }
    }
}