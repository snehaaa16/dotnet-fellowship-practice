using _08_Inheritance;

Console.WriteLine("===== Animal Hierarchy =====");

AnimalHierarchy animal;

animal = new Dog("Tommy", 3);
animal.DisplayDetails();
animal.MakeSound();

Console.WriteLine();

animal = new Cat("Kitty", 2);
animal.DisplayDetails();
animal.MakeSound();

Console.WriteLine();

animal = new Bird("Parrot", 1);
animal.DisplayDetails();
animal.MakeSound();

Console.WriteLine("===== Employee Management System =====");

EmployeeManagementSystem employee;

employee = new Manager("Sneha", 101, 80000, 10);
employee.DisplayDetails();

Console.WriteLine();

employee = new Developer("Rahul", 102, 60000, "C#");
employee.DisplayDetails();

Console.WriteLine();

employee = new Intern("Aman", 103, 15000, "6 Months");
employee.DisplayDetails();

Console.WriteLine("===== Vehicle Transport System =====");

VehicleTransportSystem[] vehicles =
{
    new Car(220, "Petrol", 5),
    new Truck(140, "Diesel", 15000),
    new Motorcycle(180, "Petrol", false)
};

foreach (VehicleTransportSystem vehicle in vehicles)
{
    vehicle.DisplayInfo();
    Console.WriteLine();
}

Console.WriteLine("===== Library Management =====");

Author author = new Author(
    "C# Programming",
    2024,
    "Robert Martin",
    "Software Engineer");

author.DisplayInfo();

Console.WriteLine("===== Smart Home Devices =====");

Thermostat thermostat =
    new Thermostat(101, "ON", 24);

thermostat.DisplayStatus();

Console.WriteLine("===== Online Retail Order Management =====");

DeliveredOrder order =
    new DeliveredOrder(101, "01-08-2026", "TRK12345", "05-08-2026");

order.DisplayDetails();
order.GetOrderStatus();

Console.WriteLine("===== Educational Course Hierarchy =====");

PaidOnlineCourse course =
    new PaidOnlineCourse("C#", "6 Months", "Udemy", true, 5000, 20);

course.DisplayCourse();

Console.WriteLine("===== Bank Account Types =====");

SavingsAccount s = new SavingsAccount("SB101", 50000, 6.5);
CheckingAccount c = new CheckingAccount("CA101", 30000, 10000);
FixedDepositAccount f = new FixedDepositAccount("FD101", 100000, 5);

s.DisplayAccountType();
Console.WriteLine();

c.DisplayAccountType();
Console.WriteLine();

f.DisplayAccountType();

Console.WriteLine("===== School System =====");

SchoolSystem person;

person = new Teacher("Sneha", 35, "Computer Science");
person.DisplayRole();

Console.WriteLine();

person = new Student("Rahul", 20, "A");
person.DisplayRole();

Console.WriteLine();

person = new Staff("Amit", 40, "Administration");
person.DisplayRole();

Console.WriteLine("===== Restaurant Management =====");

Chef chef = new Chef("Sneha", 101);
chef.PerformDuties();

Waiter waiter = new Waiter("Rahul", 102);
waiter.PerformDuties();

Console.WriteLine("===== Vehicle Management =====");

ElectricVehicle ev = new ElectricVehicle(220, "Tesla");
ev.Charge();

PetrolVehicle pv = new PetrolVehicle(180, "Hyundai");
pv.Refuel();