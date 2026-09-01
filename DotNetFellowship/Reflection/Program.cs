using Reflection;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Text;

//Get Class Information: Write a program to accept a class name as input
//and display its methods, fields, and constructors using Reflection.
//Type type = typeof(Student);

//Console.WriteLine("Methods:");
//foreach (MethodInfo method in type.GetMethods())
//{
//    Console.WriteLine(method.Name);
//}

//Console.WriteLine("\nFields:");
//foreach (FieldInfo field in type.GetFields(
//    BindingFlags.Public |
//    BindingFlags.NonPublic |
//    BindingFlags.Instance))
//{
//    Console.WriteLine(field.Name);
//}

//Console.WriteLine("\nConstructors:");
//foreach (ConstructorInfo constructor in type.GetConstructors())
//{
//    Console.WriteLine(constructor.Name);
//}

//Access Private Field: Create a class Person with a private field age.Use Reflection to modify and retrieve its value.
//Person person = new Person();

//Type type = typeof(Person);

//FieldInfo field = type.GetField(
//    "age",
//    BindingFlags.NonPublic |
//    BindingFlags.Instance
//);

//field.SetValue(person, 25);

//int age = (int)field.GetValue(person);

//Console.WriteLine("Age: " + age);


//Invoke Private Method: Define a class Calculator with a private method
//Multiply(int a, int b). Use Reflection to invoke this method and display
//the result. 
//Calculator calculator = new Calculator();

//Type type = typeof(Calculator);

//MethodInfo method = type.GetMethod(
//    "Multiply",
//    BindingFlags.NonPublic |
//    BindingFlags.Instance
//);

//object result = method.Invoke(calculator, new object[] { 5, 4 });

//Console.WriteLine("Result: " + result);

//Dynamically Create Objects: Write a program to create an instance of a
//Student class dynamically using Reflection without using the new keyword.
//Type type = typeof(Student1);

//Student1 student = (Student1)Activator.CreateInstance(type);

//student.Name = "Sneha";

//student.Display();

//MathOperations obj = new MathOperations();
//Console.Write("Enter method: ");
//string methodName = Console.ReadLine();
//Type type = typeof(MathOperations);
//MethodInfo method = type.GetMethod(methodName);
//object result = method.Invoke(obj, new object[] { 10, 5 });
//Console.WriteLine("Result: " + result);

//Type type = typeof(Student);
//AuthorAttribute attribute = type.GetCustomAttribute<AuthorAttribute>();
//Console.WriteLine("Author: " + attribute.Name);

//Type type = typeof(Configuration);
//FieldInfo field = type.GetField(
//    "API_KEY",
//    BindingFlags.NonPublic |
//    BindingFlags.Static
//);
//field.SetValue(null, "NEW_KEY");
//Console.WriteLine(field.GetValue(null));

//static T ToObject<T>(Dictionary<string, object> properties)
//{
//    T obj = Activator.CreateInstance<T>();
//    foreach (var item in properties)
//    {
//        PropertyInfo property = typeof(T).GetProperty(item.Key);
//        if (property != null)
//        {
//            property.SetValue(obj, item.Value);
//        }
//    }
//    return obj;
//}
//var data = new Dictionary<string, object>
//        {
//            { "Name", "Sneha" },
//            { "Age", 25 }
//        };
//Student3 student = ToObject<Student3>(data);
//Console.WriteLine(student.Name);
//Console.WriteLine(student.Age);

//static string ToJson(object obj)
//{
//    Type type = obj.GetType();
//    StringBuilder json = new StringBuilder();
//    json.Append("{");
//    PropertyInfo[] properties = type.GetProperties();
//    for (int i = 0; i < properties.Length; i++)
//    {
//        PropertyInfo property = properties[i];

//        json.Append("\"" + property.Name + "\":");
//        json.Append("\"" + property.GetValue(obj) + "\"");

//        if (i < properties.Length - 1)
//            json.Append(",");
//    }
//    json.Append("}");

//    return json.ToString();
//}
//Student4 student = new Student4
//{
//        Name = "Sneha",
//        Age = 25,
//        Course = "C#"
//};
//Console.WriteLine(ToJson(student));


//IGreeting proxy =
//            DispatchProxy.Create<IGreeting, LoggingProxy<IGreeting>>();

//((LoggingProxy<IGreeting>)proxy).SetTarget(new Greeting());

//proxy.SayHello();

