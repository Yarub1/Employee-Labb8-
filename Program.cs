namespace Employee
{/// <summary>
/// 
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 1: Stack
            Stack<Employee> employeeStack = new Stack<Employee>();

            // Create five Employee objects with different properties
            Employee employee1 = new Employee { Id = 1, Name = "John Doe", Gender = "Male", Salary = 50000 };
            Employee employee2 = new Employee { Id = 2, Name = "Jane Smith", Gender = "Female", Salary = 60000 };
            Employee employee3 = new Employee { Id = 3, Name = "Alex Johnson", Gender = "Male", Salary = 55000 };
            Employee employee4 = new Employee { Id = 4, Name = "Emily Brown", Gender = "Female", Salary = 65000 };
            Employee employee5 = new Employee { Id = 5, Name = "Michael Davis", Gender = "Male", Salary = 70000 };

            // Add the Employee objects to the stack
            employeeStack.Push(employee1);
            employeeStack.Push(employee2);
            employeeStack.Push(employee3);
            employeeStack.Push(employee4);
            employeeStack.Push(employee5);

            // Print all objects in the stack
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Objects in the stack:");
            foreach (Employee employee in employeeStack)
            {
                Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, Gender: {employee.Gender}, Salary: {employee.Salary}");
                Console.WriteLine($"Remaining objects in the stack: {employeeStack.Count}");
            }
            Console.ResetColor();

            // Retrieve all objects using the Pop() method
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nRetrieving objects using the Pop() method:");
            while (employeeStack.Count > 0)
            {
                Employee employee = employeeStack.Pop();
                Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, Gender: {employee.Gender}, Salary: {employee.Salary}");
                Console.WriteLine($"Remaining objects in the stack: {employeeStack.Count}");
            }
            Console.ResetColor();
            // Add all objects back to the stack using the Push() method

            employeeStack.Push(employee1);
            employeeStack.Push(employee2);
            employeeStack.Push(employee3);
            employeeStack.Push(employee4);
            employeeStack.Push(employee5);

            // Retrieve two objects using the Peek() method
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nRetrieving objects using the Peek() method:");
            Console.WriteLine($"First object: {employeeStack.Peek().Name}");
            employeeStack.Pop();
            Console.WriteLine($"Second object: {employeeStack.Peek().Name}");
            Console.WriteLine($"Remaining objects in the stack: {employeeStack.Count}");
            Console.ResetColor();

            // Check if object number 3 exists in the stack

            Console.WriteLine("\nChecking if object number 3 exists in the stack:");
            bool exists = employeeStack.Contains(employee3);
            Console.WriteLine($"Object number 3 exists in the stack: {exists}");




            // Part 2: List

            List<Employee> employeeList = new List<Employee>();

            // Add five Employee objects to the list
            employeeList.Add(employee1);
            employeeList.Add(employee2);
            employeeList.Add(employee3);
            employeeList.Add(employee4);
            employeeList.Add(employee5);

            // Check if Employee2 object exists in the list
            Console.WriteLine("\n::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("\nChecking if Employee2 object exists in the list:");
            bool existsInList = employeeList.Contains(employee2);
            Console.WriteLine(existsInList ? "Employee2 object exists in the list" : "Employee2 object does not exist in the list");
            Console.WriteLine("\n::::::::::::::::::::::::::::::::::::::::::::::::::::::::");

            // Find and print the first object in the list with Gender = "Male"
            Console.WriteLine("\nFinding the first object in the list with Gender = \"Male\":");
            Employee firstMaleEmployee = employeeList.Find(employee => employee.Gender == "Male");
            if (firstMaleEmployee != null)
            {
                Console.WriteLine($"Id: {firstMaleEmployee.Id}, Name: {firstMaleEmployee.Name}, Gender: {firstMaleEmployee.Gender}, Salary: {firstMaleEmployee.Salary}");
            }

            // Find and print all objects in the list with Gender = "Male"
            Console.WriteLine("\nFinding all objects in the list with Gender = \"Male\":");
            List<Employee> maleEmployees = employeeList.FindAll(employee => employee.Gender == "Male");
            foreach (Employee employee in maleEmployees)
            {
                Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, Gender: {employee.Gender}, Salary: {employee.Salary}");
            }

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n-------------------------------------------------------------------");
            //This is a second way to solve the assignment

            var EmployeeA = new EmployeeA();
            EmployeeA.Employee();
            Console.WriteLine("\n-------------------------------------------------------------------");

        }

    }
    }
