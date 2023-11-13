using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Employee
{
    public class EmployeeA: Employee
    {  //A class named "EmployeeA" is inherits from the "Employee" class.
       //The "EmployeeA" class contains a method named "Employee()" which serves as the entry point of the program.
       //Inside the "Employee()" method, a stack of employee objects is created using the Stack<Employee> class.
        public void Employee()
        {
            Stack<Employee> employeeStack = new Stack<Employee>();
            //The code then enters a loop that runs five times,
            //creating employee objects and adding them to the stack.
            //Each employee object is assigned a unique ID,
            //a name based on the loop index, a gender(alternating between
            //"Male" and "Female" based on the loop index), and a salary calculated based on the loop index.
            //The Push() method is used to add each employee object to the stack.


            //Create five objects and add them to the stack
            for (int i = 1; i <= 5; i++)
            {
                Employee employee = new Employee
                {
                    Id = i,
                    Name = $"Employee{i}",
                    Gender = i % 2 == 0 ? "Male" : "Female",
                    Salary = 50000 + i * 1000
                };

                employeeStack.Push(employee);
            }

            //The code then prints all the objects in the stack using a foreach loop.
            //Each employee object's properties (ID, name, gender, and salary) are displayed using string interpolation.
            //The Count property of the stack is also displayed to show the number of objects in the stack.

            // Print all objects in the stack
            Console.WriteLine("Part 1 - Stack: All objects in the stack:");
            foreach (var employee in employeeStack)
            {
                Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, Gender: {employee.Gender}, Salary: {employee.Salary:C}");
                Console.WriteLine($"Antal objekt i stacken: {employeeStack.Count}");
            }

            // Print all objects using the Pop method
            Console.WriteLine("\nPrint all objects using the Pop method:");
            while (employeeStack.Count > 0)
            {
                Employee poppedEmployee = employeeStack.Pop();
                Console.WriteLine($"Popped: Id: {poppedEmployee.Id}, Name: {poppedEmployee.Name}, Gender: {poppedEmployee.Gender}, Salary: {poppedEmployee.Salary:C}");
                Console.WriteLine($"Antal objekt kvar i stacken: {employeeStack.Count}");
            }


            //The code then enters another loop that runs five times,
            //creating employee objects and adding them to the stack using the Push() method.
            //This step is done to restore the original state of the stack before performing additional operations.


            // Add all items again through the Push method
            for (int i = 1; i <= 5; i++)
            {
                Employee employee = new Employee
                {
                    Id = i,
                    Name = $"Employee{i}",
                    Gender = i % 2 == 0 ? "Male" : "Female",
                    Salary = 50000 + i * 1000
                };

                employeeStack.Push(employee);
            }

            // Get two objects using Peek method
            Console.WriteLine("\nGet two objects using Peek method:");
            for (int i = 0; i < 2; i++)
            {
                Employee peekedEmployee = employeeStack.Peek();
                Console.WriteLine($"Peeked: Id: {peekedEmployee.Id}, Name: {peekedEmployee.Name}, Gender: {peekedEmployee.Gender}, Salary: {peekedEmployee.Salary:C}");
                Console.WriteLine($"Antal objekt kvar i stacken: {employeeStack.Count}");
                employeeStack.Pop(); // Pop the item after peeking
            }

            // Check if item number 3 is in the stack or not
            Employee employee3 = employeeStack.Contains(new Employee { Id = 3 }) ? employeeStack.Peek() : null;
            Console.WriteLine($"\nIs item number 3 in the stack: {employee3 != null}");

            // Part 2 - List
            List<Employee> employeeList = new List<Employee>();

            // Add five items to the list
            for (int i = 1; i <= 5; i++)
            {
                Employee employee = new Employee
                {
                    Id = i,
                    Name = $"Employee{i}",
                    Gender = i % 2 == 0 ? "Male" : "Female",
                    Salary = 50000 + i * 1000
                };

                employeeList.Add(employee);
            }

            // Check if a specific item is in the list with Contains()
            Employee employee2 = new Employee { Id = 2 };
            if (employeeList.Contains(employee2))
            {
                Console.WriteLine("\nDel 2 - List: Employee2 object exists in the list");
            }
            else
            {
                Console.WriteLine("\nDel 2 - List: Employee2 object does not exist in the list");
            }

            // Use Find() to find and print the first male object
            Employee firstMaleEmployee = employeeList.Find(emp => emp.Gender == "Male");
            Console.WriteLine($"\nFörsta manliga objektet i listan: Id: {firstMaleEmployee.Id}, Name: {firstMaleEmployee.Name}, Gender: {firstMaleEmployee.Gender}, Salary: {firstMaleEmployee.Salary:C}");

            // Use FindAll() to find and print all male objects in the list
            List<Employee> allMaleEmployees = employeeList.FindAll(emp => emp.Gender == "Male");
            Console.WriteLine("\nAlla manliga objekt i listan:");
            foreach (var maleEmployee in allMaleEmployees)
            {
                Console.WriteLine($"Id: {maleEmployee.Id}, Name: {maleEmployee.Name}, Gender: {maleEmployee.Gender}, Salary: {maleEmployee.Salary:C}");
            }
        }
    }



    }







