public class Employee
{
    public string FullName { get; set; }
    public string Position { get; set; }

    public Employee(string fullName, string position)
    {
        FullName = fullName;
        Position = position;
    }
}

public class Department
{
    public string Name { get; set; }
    public List<Employee> Employees { get; set; }
    public List<Department> SubDepartments { get; set; }

    public Department(string name)
    {
        Name = name;
        Employees = new List<Employee>();
        SubDepartments = new List<Department>();
    }

    public void AddEmployee(Employee employee)
    {
        Employees.Add(employee);
    }

    public void AddSubDepartment(Department subDepartment)
    {
        SubDepartments.Add(subDepartment);
    }
}

public class University
{
    public List<Department> Departments { get; set; }

    public University()
    {
        Departments = new List<Department>();
    }

    public void AddDepartment(Department department)
    {
        Departments.Add(department);
    }
}

class Program
{
    static void Main()
    {
        Employee emp1 = new Employee("Василь Васильович", "Викладач");
        Employee emp2 = new Employee("Андрій Васильович", "Викладач");

        Department dept1 = new Department("Athletics faculty");
        dept1.AddEmployee(emp1);

        Department dept2 = new Department("Faculty of Math and Digital Technologies");
        dept2.AddEmployee(emp2);

        University university = new University();
        university.AddDepartment(dept1);
        university.AddDepartment(dept2);
        
    }
}