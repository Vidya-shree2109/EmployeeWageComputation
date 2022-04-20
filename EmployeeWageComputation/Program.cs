using EmployeeWageComputation;

EmployeeWageUsingClass samsung = new EmployeeWageUsingClass("Samsung", 20, 5, 10);
EmployeeWageUsingClass reliance = new EmployeeWageUsingClass("Reliance", 10, 4, 10);
EmployeeWageUsingClass airtel = new EmployeeWageUsingClass("Airtel", 30, 5, 20);
samsung.ComputeEmployeeWage();
Console.WriteLine(samsung.displaySalary() + "\n");
reliance.ComputeEmployeeWage();
Console.WriteLine(reliance.displaySalary() + "\n");
airtel.ComputeEmployeeWage();
Console.WriteLine(airtel.displaySalary() + "\n");