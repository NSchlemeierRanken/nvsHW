using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB02_EmployeeSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = CreateEmployees();
            bool exitProgram = false;

            while (!exitProgram)
            {
                Console.WriteLine("\nEnter 1 to show all employees by last name in ascending order.");
                Console.WriteLine("Enter 2 to show all employees by social security number in ascending order.");
                Console.WriteLine("Enter 3 to show all employees by city in ascending order.");
                Console.WriteLine("Enter 4 to show all employees by state in ascending order.");
                Console.WriteLine("Enter 5 to show all employees by zipcode in ascending order.");
                Console.WriteLine("Enter 6 to search employees by last name.");
                Console.WriteLine("Enter 7 to search employees by address.");
                Console.WriteLine("Enter 8 to search employees by city.");
                Console.WriteLine("Enter 9 to exit the program.");
                Console.Write("Select an option: ");

                if (int.TryParse(Console.ReadLine(), out int option))
                {
                    switch (option)
                    {
                        case 1:
                            DisplaySorted(employees, "LastName");
                            break;
                        case 2:
                            DisplaySorted(employees, "SocialSecurityNumber");
                            break;
                        case 3:
                            DisplaySorted(employees, "City");
                            break;
                        case 4:
                            DisplaySorted(employees, "State");
                            break;
                        case 5:
                            DisplaySorted(employees, "ZipCode");
                            break;
                        case 6:
                            SearchEmployees(employees, "LastName");
                            break;
                        case 7:
                            SearchEmployees(employees, "Address");
                            break;
                        case 8:
                            SearchEmployees(employees, "City");
                            break;
                        case 9:
                            exitProgram = true;
                            break;
                        default:
                            Console.WriteLine("Invalid option, please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a number.");
                }
            }
        }
        public static void DisplaySorted(List<Employee> employees, string sortBy)
        {
            var propertyInfo = typeof(Employee).GetProperty(sortBy);
            if (propertyInfo == null)
            {
                Console.WriteLine("Invalid sorting parameter.");
                return;
            }

            var sortedEmployees = employees.OrderBy(e => propertyInfo.GetValue(e, null)).ToList();
            foreach (var emp in sortedEmployees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}, SSN: {emp.SocialSecurityNumber}, Address: {emp.Address}, City: {emp.City}, State: {emp.State}, ZipCode: {emp.ZipCode}");
            }
        }
        public static void SearchEmployees(List<Employee> employees, string searchBy)
        {
            Console.WriteLine($"Enter the {searchBy} to search for:");
            string criteria = Console.ReadLine();
            var results = employees.Where(e => e.GetType().GetProperty(searchBy).GetValue(e, null).ToString().IndexOf(criteria, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

            if (results.Any())
            {
                foreach (var emp in results)
                {
                    Console.WriteLine($"{emp.FirstName} {emp.LastName}, SSN: {emp.SocialSecurityNumber}, Address: {emp.Address}, City: {emp.City}, State: {emp.State}, ZipCode: {emp.ZipCode}");
                }
            }
            else
            {
                Console.WriteLine("No employees found.");
            }
        }

        public class Employee
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string SocialSecurityNumber { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string ZipCode { get; set; }

            public Employee(string firstName, string lastName, string ssn, string address, string city, string state, string zipCode)
            {
                FirstName = firstName;
                LastName = lastName;
                SocialSecurityNumber = ssn;
                Address = address;
                City = city;
                State = state;
                ZipCode = zipCode;
            }
        }

        public static List<Employee> CreateEmployees()
        {
            return new List<Employee>
            {
                new Employee("Tony", "Stark", "123-45-6789", "1 Highland Ave", "Highland", "IL", "62249"),
                new Employee("Mark", "Spector", "223-45-6789", "1 Main Street", "Belleville", "IL", "62220"),
                new Employee("Phil", "Coulson", "323-45-6789", "2 Main Street", "Belleville", "IL", "62220"),
                new Employee("Steven", "Strange", "423-45-6789", "3 Main Street", "Belleville", "IL", "62220"),
                new Employee("Clint", "Barton", "523-45-6789", "4 Main Street", "Belleville", "IL", "62220"),
                new Employee("Harold", "Hogan", "623-45-6789", "5 Main Street", "Belleville", "IL", "62220"),
                new Employee("Bruce", "Banner", "723-45-6789", "6 Main Street", "Belleville", "IL", "62220"),
                new Employee("Nick", "Fury", "823-45-6789", "1 Park Ave", "St. Louis", "MO", "63101"),
                new Employee("Bobbi", "Morse", "923-45-6789", "2 Park Ave", "St. Louis", "MO", "63101"),
                new Employee("Wanda", "Maximoff", "024-45-6789", "3 Park Ave", "St. Louis", "MO", "63101"),
                new Employee("Pietro", "Maximoff", "125-45-6789", "4 Park Ave", "St. Louis", "MO", "63101"),
                new Employee("Peter", "Quill", "226-45-6789", "5 Park Ave", "St. Louis", "MO", "63101"),
                new Employee("Peter", "Parker", "327-45-6789", "6 Park Ave", "St. Louis", "MO", "63101"),
                new Employee("Thor", "Odinson", "428-45-6789", "7 Park Ave", "St. Louis", "MO", "63101"),
                new Employee("Odin", "Borson", "529-45-6789", "8 Park Ave", "St. Louis", "MO", "63101"),
                new Employee("James", "Rhodes", "630-45-6789", "9 Park Ave", "St. Louis", "MO", "63101"),
                new Employee("Bucky", "Barnes", "731-45-6789", "10 Park Ave", "St. Louis", "MO", "63101"),
                new Employee("Carol", "Danvers", "832-45-6789", "11 Park Ave", "St. Louis", "MO", "63101"),
                new Employee("James", "Howlett", "933-45-6789", "12 Park Ave", "St. Louis", "MO", "63101"),
                new Employee("Emma", "Frost", "034-45-6789", "13 Park Ave", "St. Louis", "MO", "63101"),
            };
        }

    }
}
