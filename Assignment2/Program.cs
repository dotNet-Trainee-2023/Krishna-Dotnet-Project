// See https://aka.ms/new-console-template for more information
using Assignment2;

List<employee> employees = new();
var csvfile = File.ReadAllLines(@"D:\employees.csv").ToList();
foreach (var csvdetails in csvfile
    .Select((val1, val2) => new { Value = val1, Index = val2 }))
{
    if (csvdetails.Index == 0)
    {
        continue;
    }
    string[] values = csvdetails.Value.Split(',');
    if (values.Length == 10)
    {
        employee employee = new employee
        {
            fname = values[0],
            lname = values[1],
            email = values[2],
            Phone = values[3],
            gen = values[4],
            age = values[5],
            jt = values[6],
            YoE = values[7],
            Salary = values[8],
            dept = values[9]
        };
        employees.Add(employee);
    }
    else
    {
        Console.WriteLine("Employee columns mismatch");
    }

}


var groupByDepartment = employees.GroupBy(e => e.dept);
foreach (var group in groupByDepartment)
{
    Console.WriteLine($"Department:  {group.Key}");
    foreach (var employee in group)
    {
        Console.WriteLine($"{employee.fname} {employee.lname} | {employee.jt} | {employee.dept} ");
    }
    Console.WriteLine();

}
Console.WriteLine();



var promanager = employees.Where(e => e.jt == "Project Manager")
    .OrderByDescending(e => e.Salary)
    .FirstOrDefault();
Console.WriteLine($"PROJECT MANAGER WITH HIGHEST SALARY: {promanager.fname} {promanager.lname} with salary {promanager.Salary}");
Console.WriteLine();


var web = employees.Where(e => e.jt == "Web Developer")
    .OrderByDescending(e => e.YoE).FirstOrDefault();
Console.WriteLine($"EXPERIENCED WEB DEVELOPER: {web.fname} {web.lname} with {web.YoE} years of experience");
Console.WriteLine();



var jobGroup = employees.GroupBy(e => e.jt);
foreach (var group in jobGroup)
{
    string jobTitle = group.Key;
    decimal averageSalary = group.Average(e => (decimal.Parse(e.Salary)));

    Console.WriteLine($"Job Title: {jobTitle}");
    Console.WriteLine($"Average Salary: {averageSalary}");
    Console.WriteLine();
}


var employeeCount = employees.GroupBy(e => e.gen);
foreach (var group in employeeCount)
{
    var count = group.Count();
    Console.WriteLine($"Number of {group.Key} Employees: {count} ");
}
        
