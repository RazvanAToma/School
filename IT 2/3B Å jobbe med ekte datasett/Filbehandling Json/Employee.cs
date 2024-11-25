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
}
