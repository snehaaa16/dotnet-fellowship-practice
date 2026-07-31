//using _07_OOPS.Constructors.Level1;

//Console.WriteLine("===== Book Class =====");
//Book b1 = new Book();
//b1.DisplayBook();
//Book b2 = new Book("Clean Code", "Robert Martin", 799);
//b2.DisplayBook();

//Console.WriteLine("===== Circle Class =====");
//Circle c1 = new Circle();
//c1.DisplayCircle();
//Circle c2 = new Circle(7);
//c2.DisplayCircle();

//Console.WriteLine("===== Person (Copy Constructor) =====");
//Person p1 = new Person("Sneha", 20);
//Person p2 = new Person(p1);
//p1.DisplayPerson();
//p2.DisplayPerson();

//Console.WriteLine("===== Hotel Booking =====");
//HotelBooking h1 = new HotelBooking();
//HotelBooking h2 = new HotelBooking("Rahul", "Deluxe", 3);
//HotelBooking h3 = new HotelBooking(h2);
//h1.DisplayBooking();
//h2.DisplayBooking();
//h3.DisplayBooking();

//Console.WriteLine("===== Library Book =====");
//LibraryBook b1 = new LibraryBook();
//b1.DisplayBook();
//b1.BorrowBook();
//b1.DisplayBook();

//LibraryBook b2 = new LibraryBook("C# in Depth", "Jon Skeet", 1200, true);
//b2.DisplayBook();
//b2.BorrowBook();
//b2.DisplayBook();

//Console.WriteLine();

//Console.WriteLine("===== Car Rental =====");

//CarRental c1 = new CarRental();
//c1.DisplayRentalDetails();

//CarRental c2 = new CarRental("Sneha", "Hyundai Creta", 5);
//c2.DisplayRentalDetails();

using _07_OOPS.AccessModifiers;
using _07_OOPS.Constructors.Level1;
using _07_OOPS.StaticAndInstance;

ConstructorBook book1 = new ConstructorBook();
book1.DisplayBook();

ConstructorBook book2 = new ConstructorBook("Clean Code", "Robert Martin", 799);
book2.DisplayBook();

Circle circle1 = new Circle();
circle1.DisplayCircle();

Circle circle2 = new Circle(7);
circle2.DisplayCircle();

Person person1 = new Person("Sneha", 20);
Person person2 = new Person(person1);

person1.DisplayPerson();
person2.DisplayPerson();

HotelBooking booking1 = new HotelBooking();
HotelBooking booking2 = new HotelBooking("Rahul", "Deluxe", 3);
HotelBooking booking3 = new HotelBooking(booking2);

booking1.DisplayBooking();
booking2.DisplayBooking();
booking3.DisplayBooking();

LibraryBook libraryBook1 = new LibraryBook();
libraryBook1.DisplayBook();
libraryBook1.BorrowBook();

LibraryBook libraryBook2 = new LibraryBook("C# in Depth", "Jon Skeet", 1200, true);
libraryBook2.DisplayBook();
libraryBook2.BorrowBook();

CarRental rental1 = new CarRental();
rental1.DisplayRentalDetails();

CarRental rental2 = new CarRental("Sneha", "Creta", 5);
rental2.DisplayRentalDetails();

Console.WriteLine("===== Product Inventory =====");

Product p1 = new Product("Laptop", 65000);
Product p2 = new Product("Mouse", 1200);

p1.DisplayProductDetails();
p2.DisplayProductDetails();

Product.DisplayTotalProducts();

Console.WriteLine("===== Online Course Management =====");

Course c1 = new Course("C#", 6, 25000);
Course c2 = new Course("Java", 5, 22000);

c1.DisplayCourseDetails();
c2.DisplayCourseDetails();

Console.WriteLine("After Updating Institute Name\n");

Course.UpdateInstituteName("Chitkara University");

c1.DisplayCourseDetails();
c2.DisplayCourseDetails();

Console.WriteLine("===== Vehicle Registration =====");

Vehicle v1 = new Vehicle("Sneha", "Car");
Vehicle v2 = new Vehicle("Rahul", "Bike");

v1.DisplayVehicleDetails();
v2.DisplayVehicleDetails();

Console.WriteLine("Updating Registration Fee...\n");

Vehicle.UpdateRegistrationFee(7500);

v1.DisplayVehicleDetails();
v2.DisplayVehicleDetails();

Student s1 = new Student(101, "Sneha", 8.8);
s1.DisplayStudent();

Console.WriteLine();

PostgraduateStudent pg = new PostgraduateStudent(201, "Rahul", 9.5);
pg.DisplayDetails();

BankAccount b1 = new BankAccount("123456789", "Sneha", 50000);

b1.DisplayAccount();

b1.SetBalance(65000);

Console.WriteLine("After Updating Balance\n");

b1.DisplayAccount();

SavingsAccount sa1 = new SavingsAccount("12345", "Sneha", 50000);

sa1.DisplaySavingsAccount();