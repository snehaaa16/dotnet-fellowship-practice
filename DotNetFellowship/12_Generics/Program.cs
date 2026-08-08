using _10_Generics;
using _12_Generics;

Console.WriteLine("===== Smart Warehouse Management System =====");

Storage<Electronics> electronicsStorage = new Storage<Electronics>();

electronicsStorage.AddItem(
    new Electronics(101, "Laptop", "Dell"));

electronicsStorage.AddItem(
    new Electronics(102, "Mobile", "Samsung"));

Console.WriteLine("Electronics:");

electronicsStorage.DisplayAllItems();


Storage<Groceries> groceryStorage = new Storage<Groceries>();

groceryStorage.AddItem(
    new Groceries(201, "Rice", "20-12-2026"));

groceryStorage.AddItem(
    new Groceries(202, "Milk", "15-08-2026"));

Console.WriteLine("Groceries:");

groceryStorage.DisplayAllItems();


Storage<Furniture> furnitureStorage = new Storage<Furniture>();

furnitureStorage.AddItem(
    new Furniture(301, "Table", "Wood"));

furnitureStorage.AddItem(
    new Furniture(302, "Chair", "Metal"));

Console.WriteLine("Furniture:");

furnitureStorage.DisplayAllItems();


Console.WriteLine("===== Dynamic Online Marketplace =====");

GenericProduct<BookCategory> book =
    new GenericProduct<BookCategory>(
        "C# Programming",
        1000,
        new BookCategory("Programming"));

GenericProduct<ClothingCategory> clothing =
    new GenericProduct<ClothingCategory>(
        "T-Shirt",
        1500,
        new ClothingCategory("Large"));

book.DisplayDetails();

Console.WriteLine();

clothing.DisplayDetails();

Console.WriteLine();

Console.WriteLine("===== Applying Discount =====");

Product product = new Product("Laptop", 60000);

product.DisplayDetails();

DynamicOnlineMarketplace.ApplyDiscount(product, 10);

Console.WriteLine("===== University Course Management System =====");

Course<ExamCourse> examCourse =
    new Course<ExamCourse>(
        "Data Structures",
        "CSE",
        new ExamCourse(100));

Course<AssignmentCourse> assignmentCourse =
    new Course<AssignmentCourse>(
        "Software Engineering",
        "CSE",
        new AssignmentCourse(5));

examCourse.DisplayCourse();

Console.WriteLine();

assignmentCourse.DisplayCourse();

Console.WriteLine();

Console.WriteLine("===== Course Evaluation List =====");

List<CourseType> courses = new List<CourseType>
{
    new ExamCourse(80),
    new AssignmentCourse(4),
    new ExamCourse(90)
};

foreach (CourseType course in courses)
{
    course.DisplayEvaluation();
    Console.WriteLine();
}

Console.WriteLine("===== Personalized Meal Plan Generator =====");

Meal<VegetarianMeal> vegetarian =
    new Meal<VegetarianMeal>(
        new VegetarianMeal("Paneer Rice"));

Meal<VeganMeal> vegan =
    new Meal<VeganMeal>(
        new VeganMeal("Vegan Salad"));

Meal<KetoMeal> keto =
    new Meal<KetoMeal>(
        new KetoMeal("Egg and Avocado"));

vegetarian.DisplayMeal();

Console.WriteLine();

vegan.DisplayMeal();

Console.WriteLine();

keto.DisplayMeal();

Console.WriteLine();

Console.WriteLine("===== Generic Method =====");

PersonalizedMealPlanGenerator.GenerateMealPlan(
    new VegetarianMeal("Vegetable Sandwich"));

Console.WriteLine();

PersonalizedMealPlanGenerator.GenerateMealPlan(
    new VeganMeal("Tofu Salad"));


Console.WriteLine("===== AI Resume Screening System =====");

Resume<SoftwareEngineer> softwareResume =
    new Resume<SoftwareEngineer>(
        "Sneha",
        new SoftwareEngineer("C#"));

Resume<DataScientist> dataResume =
    new Resume<DataScientist>(
        "Rahul",
        new DataScientist("Machine Learning"));

softwareResume.DisplayResume();

Console.WriteLine();

dataResume.DisplayResume();

Console.WriteLine();

AIResumeScreeningSystem.ScreenResume(softwareResume);

Console.WriteLine();

AIResumeScreeningSystem.ScreenResume(dataResume);

Console.WriteLine();

Console.WriteLine("===== Resume List =====");

List<JobRole> jobRoles = new List<JobRole>
{
    new SoftwareEngineer("Java"),
    new SoftwareEngineer("C#"),
    new DataScientist("Python")
};

foreach (JobRole role in jobRoles)
{
    role.DisplayRole();
    Console.WriteLine();
}