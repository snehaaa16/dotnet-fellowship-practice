using _09_AbstractClass_Interface;

Console.WriteLine("===== Employee Management System =====");

EmployeeManagementSystem[] employees =
{
    new FullTimeEmployee(101,"Sneha",50000),
    new PartTimeEmployee(102,"Rahul",500,80)
};

((FullTimeEmployee)employees[0]).AssignDepartment("IT");
((PartTimeEmployee)employees[1]).AssignDepartment("HR");

foreach (EmployeeManagementSystem employee in employees)
{
    employee.DisplayDetails();

    if (employee is IDepartment department)
    {
        department.GetDepartmentDetails();
    }

    Console.WriteLine("Salary : " + employee.CalculateSalary());
    Console.WriteLine();
}

Console.WriteLine("===== E-Commerce Platform =====");

ECommercePlatform[] products =
{
    new Electronics(101,"Laptop",60000),
    new Clothing(102,"T-Shirt",1500),
    new Groceries(103,"Rice",800)
};

foreach (ECommercePlatform product in products)
{
    product.DisplayDetails();

    double tax = 0;

    if (product is ITaxable taxable)
    {
        tax = taxable.CalculateTax();
        taxable.GetTaxDetails();
    }

    double discount = product.CalculateDiscount();
    Console.WriteLine("Discount : " + discount);

    double finalPrice = product.Price + tax - discount;
    Console.WriteLine("Final Price : " + finalPrice);

    Console.WriteLine();
}

Console.WriteLine("===== Vehicle Rental System =====");

VehicleRentalSystem[] vehicles =
{
    new Car("PB10A101","Car",2000,"INS101"),
    new Bike("PB10B102","Bike",800,"INS102"),
    new Truck("PB10T103","Truck",5000,"INS103")
};

foreach (VehicleRentalSystem vehicle in vehicles)
{
    vehicle.DisplayDetails();

    Console.WriteLine("Rental Cost : " + vehicle.CalculateRentalCost(5));

    if (vehicle is IInsurable insurance)
    {
        insurance.GetInsuranceDetails();
    }

    Console.WriteLine();
}

Console.WriteLine("===== Banking System =====");

BankingSystem[] accounts =
{
    new SavingsAccount("SB101","Sneha",50000),
    new CurrentAccount("CA102","Rahul",80000)
};

foreach (BankingSystem account in accounts)
{
    account.DisplayDetails();

    Console.WriteLine("Interest : " + account.CalculateInterest());

    if (account is ILoanable loan)
    {
        loan.ApplyForLoan();
        Console.WriteLine("Loan Eligibility : " + loan.CalculateLoanEligibility());
    }

    Console.WriteLine();
}

Console.WriteLine("===== Library Management System =====");

LibraryManagementSystem[] items =
{
    new Book(101,"C#","Microsoft"),
    new Magazine(102,"Forbes","ABC"),
    new DVD(103,"Avengers","Marvel")
};

foreach (LibraryManagementSystem item in items)
{
    item.GetItemDetails();

    Console.WriteLine("Loan Duration : " + item.GetLoanDuration() + " Days");

    if (item is IReservable reserve)
    {
        reserve.CheckAvailability();
        reserve.ReserveItem();
    }

    Console.WriteLine();
}

Console.WriteLine("===== Online Food Delivery System =====");

OnlineFoodDeliverySystem[] foods =
{
    new VegItem("Paneer Pizza",300,2),
    new NonVegItem("Chicken Burger",250,2)
};

foreach (OnlineFoodDeliverySystem food in foods)
{
    food.GetItemDetails();

    Console.WriteLine("Total Price : " + food.CalculateTotalPrice());

    if (food is IDiscountable discount)
    {
        discount.GetDiscountDetails();
    }

    Console.WriteLine();
}

Console.WriteLine("===== Hospital Patient Management =====");

HospitalPatientManagement[] patients =
{
    new InPatient(101,"Sneha",21),
    new OutPatient(102,"Rahul",25)
};

((InPatient)patients[0]).AddRecord("Admitted for Surgery");
((OutPatient)patients[1]).AddRecord("General Checkup");

foreach (HospitalPatientManagement patient in patients)
{
    patient.GetPatientDetails();

    Console.WriteLine("Bill : " + patient.CalculateBill());

    if (patient is IMedicalRecord record)
    {
        record.ViewRecords();
    }

    Console.WriteLine();
}

Console.WriteLine("===== Ride Hailing Application =====");

// CHANGED: vehicles -> rideVehicles
RideHailingApplication[] rideVehicles =
{
    new Car(101,"Sneha",20),
    new Bike(102,"Rahul",10),
    new Auto(103,"Amit",15)
};

((Car)rideVehicles[0]).UpdateLocation("Chandigarh");
((Bike)rideVehicles[1]).UpdateLocation("Mohali");
((Auto)rideVehicles[2]).UpdateLocation("Zirakpur");

foreach (RideHailingApplication vehicle in rideVehicles)
{
    vehicle.GetVehicleDetails();

    Console.WriteLine("Fare (10 Km) : " + vehicle.CalculateFare(10));

    if (vehicle is IGPS gps)
    {
        gps.GetCurrentLocation();
    }

    Console.WriteLine();
}