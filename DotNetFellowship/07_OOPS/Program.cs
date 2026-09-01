////using _07_OOPS.Constructors.Level1;

////Console.WriteLine("===== Book Class =====");
////Book b1 = new Book();
////b1.DisplayBook();
////Book b2 = new Book("Clean Code", "Robert Martin", 799);
////b2.DisplayBook();

////Console.WriteLine("===== Circle Class =====");
////Circle c1 = new Circle();
////c1.DisplayCircle();
////Circle c2 = new Circle(7);
////c2.DisplayCircle();

////Console.WriteLine("===== Person (Copy Constructor) =====");
////Person p1 = new Person("Sneha", 20);
////Person p2 = new Person(p1);
////p1.DisplayPerson();
////p2.DisplayPerson();

////Console.WriteLine("===== Hotel Booking =====");
////HotelBooking h1 = new HotelBooking();
////HotelBooking h2 = new HotelBooking("Rahul", "Deluxe", 3);
////HotelBooking h3 = new HotelBooking(h2);
////h1.DisplayBooking();
////h2.DisplayBooking();
////h3.DisplayBooking();

////Console.WriteLine("===== Library Book =====");
////LibraryBook b1 = new LibraryBook();
////b1.DisplayBook();
////b1.BorrowBook();
////b1.DisplayBook();

////LibraryBook b2 = new LibraryBook("C# in Depth", "Jon Skeet", 1200, true);
////b2.DisplayBook();
////b2.BorrowBook();
////b2.DisplayBook();

////Console.WriteLine();

////Console.WriteLine("===== Car Rental =====");

////CarRental c1 = new CarRental();
////c1.DisplayRentalDetails();

////CarRental c2 = new CarRental("Sneha", "Hyundai Creta", 5);
////c2.DisplayRentalDetails();

//using _07_OOPS.AccessModifiers;
//using _07_OOPS.Constructors.Level1;
//using _07_OOPS.Static_This_Readonly_IsOperator;
//using _07_OOPS.StaticAndInstance;
//using System.ComponentModel.DataAnnotations;
//using System.Runtime.Intrinsics.X86;
//using System.Security.Principal;
//using System.Threading.Channels;
//using System.Xml;
//using System.Xml.Linq;

//ConstructorBook book1 = new ConstructorBook();
//book1.DisplayBook();

//ConstructorBook book2 = new ConstructorBook("Clean Code", "Robert Martin", 799);
//book2.DisplayBook();

//Circle circle1 = new Circle();
//circle1.DisplayCircle();

//Circle circle2 = new Circle(7);
//circle2.DisplayCircle();

//Person person1 = new Person("Sneha", 20);
//Person person2 = new Person(person1);

//person1.DisplayPerson();
//person2.DisplayPerson();

//HotelBooking booking1 = new HotelBooking();
//HotelBooking booking2 = new HotelBooking("Rahul", "Deluxe", 3);
//HotelBooking booking3 = new HotelBooking(booking2);

//booking1.DisplayBooking();
//booking2.DisplayBooking();
//booking3.DisplayBooking();

//LibraryBook libraryBook1 = new LibraryBook();
//libraryBook1.DisplayBook();
//libraryBook1.BorrowBook();

//LibraryBook libraryBook2 = new LibraryBook("C# in Depth", "Jon Skeet", 1200, true);
//libraryBook2.DisplayBook();
//libraryBook2.BorrowBook();

//CarRental rental1 = new CarRental();
//rental1.DisplayRentalDetails();

//CarRental rental2 = new CarRental("Sneha", "Creta", 5);
//rental2.DisplayRentalDetails();

//Console.WriteLine("===== Product Inventory =====");

//Product p1 = new Product("Laptop", 65000);
//Product p2 = new Product("Mouse", 1200);

//p1.DisplayProductDetails();
//p2.DisplayProductDetails();

//Product.DisplayTotalProducts();

//Console.WriteLine("===== Online Course Management =====");

//Course c1 = new Course("C#", 6, 25000);
//Course c2 = new Course("Java", 5, 22000);

//c1.DisplayCourseDetails();
//c2.DisplayCourseDetails();

//Console.WriteLine("After Updating Institute Name\n");

//Course.UpdateInstituteName("Chitkara University");

//c1.DisplayCourseDetails();
//c2.DisplayCourseDetails();

//Console.WriteLine("===== Vehicle Registration =====");

//Vehicle v1 = new Vehicle("Sneha", "Car");
//Vehicle v2 = new Vehicle("Rahul", "Bike");

//v1.DisplayVehicleDetails();
//v2.DisplayVehicleDetails();

//Console.WriteLine("Updating Registration Fee...\n");

//Vehicle.UpdateRegistrationFee(7500);

//v1.DisplayVehicleDetails();
//v2.DisplayVehicleDetails();

//Student s1 = new Student(101, "Sneha", 8.8);
//s1.DisplayStudent();

//Console.WriteLine();

//PostgraduateStudent pg = new PostgraduateStudent(201, "Rahul", 9.5);
//pg.DisplayDetails();

//BankAccount b1 = new BankAccount("123456789", "Sneha", 50000);

//b1.DisplayAccount();

//b1.SetBalance(65000);

//Console.WriteLine("After Updating Balance\n");

//b1.DisplayAccount();

//SavingsAccount sa1 = new SavingsAccount("12345", "Sneha", 50000);

//sa1.DisplaySavingsAccount();

////Sample Program 1: Bank Account System
////Create a BankAccount class with the following features:
////static: 
////A static variable bankName shared across all accounts.
////A static method GetTotalAccounts() to display the total number of accounts.
////this: 
////Use this to resolve ambiguity in the constructor when initializing AccountHolderName and AccountNumber.
////readonly: 
////Use a readonly variable AccountNumber to ensure it cannot be changed once assigned.
////is operator: 
////Check if an account object is an instance of the BankAccount class before displaying its details


//BankAccountSystem account1 = new BankAccountSystem("Sneha", 1001);
//BankAccountSystem account2 = new BankAccountSystem("Rahul", 1002);

//if (account1 is BankAccountSystem)
//{
//    account1.DisplayDetails();
//}

//Console.WriteLine();

//if (account2 is BankAccountSystem)
//{
//    account2.DisplayDetails();
//}

//Console.WriteLine();

//BankAccountSystem.GetTotalAccounts();

////Sample Program 2: Library Management System
////Create a Book class to manage library books with the following features:
////static: 
////A static variable LibraryName shared across all books.
////A static method DisplayLibraryName() to print the library name.
////this: 
////Use this to initialize Title, Author, and ISBN in the constructor.
////readonly: 
////Use a readonly variable ISBN to ensure the unique identifier of a book cannot be changed.
////is operator: 
////Verify if an object is an instance of the Book class before displaying its details.

//Console.WriteLine("===== Library Management System =====");

//LibraryManagementSystem booklib1 = new LibraryManagementSystem(
//    "C# Programming",
//    "John",
//    "ISBN101");

//LibraryManagementSystem booklib2 = new LibraryManagementSystem(
//    "ASP.NET Core",
//    "James",
//    "ISBN102");

//if (book1 is LibraryManagementSystem)
//{
//    booklib1.DisplayDetails();
//}

//Console.WriteLine();

//if (book2 is LibraryManagementSystem)
//{
//    booklib2.DisplayDetails();
//}

//Console.WriteLine();

//LibraryManagementSystem.DisplayLibraryName();
////Sample Program 3: Employee Management System
////Design an Employee class with the following features:
////static: 
////A static variable CompanyName shared by all employees.
////A static method DisplayTotalEmployees() to show the total number of employees.
////this: 
////Use this to initialize Name, Id, and Designation in the constructor.
////readonly: 
////Use a readonly variable Id for the employee ID, which cannot be modified after assignment.
////is operator: 
////Check if a given object is an instance of the Employee class before printing the employee details.
//Console.WriteLine("===== Employee Management System =====");

//EmployeeManagementSystem employee1 =
//    new EmployeeManagementSystem("Sneha", 101, "Software Developer");

//EmployeeManagementSystem employee2 =
//    new EmployeeManagementSystem("Rahul", 102, "QA Engineer");

//if (employee1 is EmployeeManagementSystem)
//{
//    employee1.DisplayDetails();
//}

//Console.WriteLine();

//if (employee2 is EmployeeManagementSystem)
//{
//    employee2.DisplayDetails();
//}

//Console.WriteLine();

//EmployeeManagementSystem.DisplayTotalEmployees();

////Sample Program 4: Shopping Cart System
////Create a Product class to manage shopping cart items with the following features:
////static: 
////A static variable Discount shared by all products.
////A static method UpdateDiscount() to modify the discount percentage.
////this: 
////Use this to initialize ProductName, Price, and Quantity in the constructor.
////readonly: 
////Use a readonly variable ProductID to ensure each product has a unique identifier that cannot be changed.
////is operator: 
////Validate whether an object is an instance of the Product class before processing its details.
//Console.WriteLine("===== Shopping Cart System =====");

//ShoppingCartSystem product1 =
//    new ShoppingCartSystem("Laptop", 65000, 2, 1001);

//ShoppingCartSystem product2 =
//    new ShoppingCartSystem("Mouse", 1200, 5, 1002);

//if (product1 is ShoppingCartSystem)
//{
//    product1.DisplayDetails();
//}

//Console.WriteLine();

//if (product2 is ShoppingCartSystem)
//{
//    product2.DisplayDetails();
//}

//Console.WriteLine();

//Console.WriteLine("After Updating Discount\n");

//ShoppingCartSystem.UpdateDiscount(20);

//product1.DisplayDetails();

//Console.WriteLine();

//product2.DisplayDetails();


////Sample Program 5: University Student Management
////Create a Student class to manage student data with the following features:
////static: 
////A static variable UniversityName shared across all students.
////A static method DisplayTotalStudents() to show the number of students enrolled.
////this: 
////Use this in the constructor to initialize Name, RollNumber, and Grade.
////readonly: 
////Use a readonly variable RollNumber for each student that cannot be changed.
////is operator: 
////Check if a given object is an instance of the Student class before performing operations like displaying or updating grades.
//Console.WriteLine("===== University Student Management =====");

//UniversityStudentManagement student1 =
//    new UniversityStudentManagement("Sneha", 101, 'A');

//UniversityStudentManagement student2 =
//    new UniversityStudentManagement("Rahul", 102, 'B');

//if (student1 is UniversityStudentManagement)
//{
//    student1.DisplayDetails();
//}

//Console.WriteLine();

//if (student2 is UniversityStudentManagement)
//{
//    student2.DisplayDetails();
//}

//Console.WriteLine();

//UniversityStudentManagement.DisplayTotalStudents();

////Sample Program 6: Vehicle Registration System
////Create a Vehicle class with the following features:
////static: 
////A static variable RegistrationFee common for all vehicles.
////A static method UpdateRegistrationFee() to modify the fee.
////this: 
////Use this to initialize OwnerName, VehicleType, and RegistrationNumber in the constructor.
////readonly: 
////Use a readonly variable RegistrationNumber to uniquely identify each vehicle.
////is operator: 
////Check if an object belongs to the Vehicle class before displaying its registration details.
//Console.WriteLine("===== Vehicle Registration System =====");

//VehicleRegistrationSystem vehicle1 =
//    new VehicleRegistrationSystem("Sneha", "Car", "PB10AB1234");

//VehicleRegistrationSystem vehicle2 =
//    new VehicleRegistrationSystem("Rahul", "Bike", "PB65XY5678");

//if (vehicle1 is VehicleRegistrationSystem)
//{
//    vehicle1.DisplayDetails();
//}

//Console.WriteLine();

//if (vehicle2 is VehicleRegistrationSystem)
//{
//    vehicle2.DisplayDetails();
//}

//Console.WriteLine();

//Console.WriteLine("After Updating Registration Fee\n");

//VehicleRegistrationSystem.UpdateRegistrationFee(7500);

//vehicle1.DisplayDetails();

//Console.WriteLine();

//vehicle2.DisplayDetails();
////Sample Program 7: Hospital Management System
////Create a Patient class with the following features:
////static: 
////A static variable HospitalName shared among all patients.
////A static method GetTotalPatients() to count the total patients admitted.
////this: 
////Use this to initialize Name, Age, and Ailment in the constructor.
////readonly: 
////Use a readonly variable PatientID to uniquely identify each patient.
////is operator: 
////Check if an object is an instance of the Patient class before displaying its details.
//Console.WriteLine("===== Hospital Management System =====");

//HospitalManagementSystem patient1 =
//    new HospitalManagementSystem("Sneha", 20, "Fever", 1001);

//HospitalManagementSystem patient2 =
//    new HospitalManagementSystem("Rahul", 25, "Cold", 1002);

//if (patient1 is HospitalManagementSystem)
//{
//    patient1.DisplayDetails();
//}

//Console.WriteLine();

//if (patient2 is HospitalManagementSystem)
//{
//    patient2.DisplayDetails();
//}

//Console.WriteLine();

//HospitalManagementSystem.GetTotalPatients();

//Console.WriteLine("-----------------------------------------------------------------------------");

using _07_OOPS.PreparatoryExecises.ClassesAndObject;

BookPractice book1=new BookPractice("The art of not giving a fuck","xyz",2000);
book1.ShowDetails();
