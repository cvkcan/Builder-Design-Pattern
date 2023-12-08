using Builder_Design_Pattern.WithAbstraction;
using Builder_Design_Pattern.WithoutAbstraction;

EmployeeBuilder employee1 = new();
var result = employee1.SetFullName("Can Cevik")
    .SetAddress("Turkey")
    .SetEmailAddress("cancevik@gmail.com")
    .BuildEmployeeBuilder();
Console.WriteLine(result );

Console.WriteLine("******");

IEmployeeBuilder2 employee2 = new SampleEmployee();
employee2.SetFullname("Can Cevik");
employee2.SetAddress("Turkey");
employee2.SetEmailAddress("cancevik@gmail.com");
var result2 = employee2.BuildEmployeeBuilder2();
Console.WriteLine(result2);


