using System;
using System.Collections.Generic;
using System.Reflection;
using _053502_GERCHIK_LAB10_.Entities;

namespace _053502_GERCHIK_LAB10_
{
    class Program
    {
        static void Main()
        {
            const string jsonPath =
                "/Users/lnxd/Desktop/BSUIR/THIRD TERM/ISP/LABS/LAB10/_053502_GERCHIK_LAB10_/json.json";

            const string dllLibPath =
                "/Users/lnxd/Desktop/BSUIR/THIRD TERM/ISP/LABS/LAB10/_053502_GERCHIK_LAB10_/ClassLibrary/bin/Debug/net5.0/ClassLibrary.dll";

            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee(23, "Vasya", true));
            employees.Add(new Employee(33, "Gena", true));
            employees.Add(new Employee(53, "Vitya", false));
            employees.Add(new Employee(45, "Vova", true));
            employees.Add(new Employee(54, "Stas", true));

            IEnumerable<Employee> data = employees;

            Assembly asm = Assembly.LoadFrom(dllLibPath);
            var type = asm.GetType("ClassLibrary.Program", true, true);

            object obj = Activator.CreateInstance(type);

            MethodInfo saveDataMethod = type.GetMethod("SaveData");
            MethodInfo readFileMethod = type.GetMethod("ReadFile");

            saveDataMethod?.Invoke(obj, new Object[] {data, jsonPath});

            var result = readFileMethod.Invoke(obj, new object[] {jsonPath});
            var resultAsList = result as List<Employee>;

            if (resultAsList != null)
                foreach (var employee in resultAsList)
                {
                    Console.WriteLine(
                        $"Age: {employee.Age.ToString()}, Name: {employee.Name}, IsVaccianted: {employee.IsVaccinated.ToString()}");
                }
        }
    }
}