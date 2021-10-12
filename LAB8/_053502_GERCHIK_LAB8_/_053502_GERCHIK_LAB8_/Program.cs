using System;
using System.Collections.Generic;
using System.IO;

namespace _053502_GERCHIK_LAB8_
{
    class Program
    {
        static void Main()
        {
            FileService fileService = new FileService();

            List<Employee> employees = new List<Employee>();

            string fileName = "file";
            string path = $@"/Users/lnxd/Desktop/BSUIR/THIRD TERM/ISP/LABS/LAB8/{fileName}.dat";

            string newFileName = "file2";
            string newPath = $@"/Users/lnxd/Desktop/BSUIR/THIRD TERM/ISP/LABS/LAB8/{newFileName}.dat";

            employees.Add(new Employee(1000, true, "Vasya"));
            employees.Add(new Employee(1100, true, "Gena"));
            employees.Add(new Employee(1200, true, "Vova"));
            employees.Add(new Employee(1300, true, "Petya"));
            employees.Add(new Employee(1400, true, "Stas"));

            try
            {
                if (File.Exists(path))
                {
                    Console.WriteLine("File Exists.");
                    File.Delete(path);
                    Console.WriteLine("File Deleted. ");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("File Doesn't Exist Yet, Creating. ");
                }

                fileService.SaveData(employees, fileName);

                File.Move(path, newPath);

                List<Employee> newEmployees = new List<Employee>();

                IEnumerable<Employee> employeesFromFile = fileService.ReadFile(newFileName);

                foreach (var employee in employeesFromFile)
                    newEmployees.Add(employee);

                newEmployees.Sort(new EmployeeComparer());

                Console.WriteLine("#########NOT SORTED#########");
                Console.WriteLine();

                for (int index = 0; index < employees.Count; index++)
                {
                    Console.WriteLine(
                        $"Name: {employees[index].Name}, Salary: {employees[index].Salary.ToString()}, Vaccinated: {employees[index].Vaccinated.ToString()}");
                }

                Console.WriteLine();
                Console.WriteLine("#########NOT SORTED#########");
                Console.WriteLine();
                Console.WriteLine("###########SORTED###########");
                Console.WriteLine();

                for (int index = 0; index < newEmployees.Count; index++)
                {
                    Console.WriteLine(
                        $"Name: {newEmployees[index].Name}, Salary: {newEmployees[index].Salary.ToString()}, Vaccinated: {newEmployees[index].Vaccinated.ToString()}");
                }

                Console.WriteLine();
                Console.WriteLine("###########SORTED###########");

                fileService.cleanUpDirectory();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}