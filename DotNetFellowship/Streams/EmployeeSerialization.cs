using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Streams
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
    }

    internal class EmployeeSerialization
    {
        static void Main()
        {
            string file = "employees.json";

            try
            {
                List<Employee> employees = new List<Employee>
                {
                    new Employee { Id = 1, Name = "Aman", Department = "IT", Salary = 50000 },
                    new Employee { Id = 2, Name = "Riya", Department = "HR", Salary = 45000 }
                };

                string json = JsonSerializer.Serialize(employees);
                File.WriteAllText(file, json);

                string data = File.ReadAllText(file);
                List<Employee> result =
                    JsonSerializer.Deserialize<List<Employee>>(data);

                foreach (Employee e in result)
                {
                    Console.WriteLine($"{e.Id} {e.Name} {e.Department} {e.Salary}");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("File error: " + ex.Message);
            }
        }
    }
}