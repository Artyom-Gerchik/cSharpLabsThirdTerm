using System;
using _053502_GERCHIK_LAB5_.Collections;

namespace _053502_GERCHIK_LAB5_.Entities
{
    public class InformationSystem
    {
        private static MyCustomCollection<Worker> _dataBase = new MyCustomCollection<Worker>();

        public static void AddBuilderFirstTime()
        {
            Worker workerToAdd = new Worker();
            bool temp = true;
            while (temp)
            {
                try
                {
                    Console.Write("Enter Builder Work Salary: ");
                    var userInput = Console.ReadLine();
                    WorkBuilder.Salary = Convert.ToInt32(userInput);
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Enter a proper value, RedNeck!");
                    continue;
                }

                temp = false;
                Console.Write("Enter worker name: ");
                var tempName = Console.ReadLine();

                bool temp1 = true;
                while (temp1)
                {
                    try
                    {
                        Console.Write("Enter work hours: ");
                        var tempHours = Console.ReadLine();
                        workerToAdd.WorkHours = Convert.ToInt32(tempHours);
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Enter a proper value, RedNeck!");
                        Console.WriteLine();
                        continue;
                    }

                    temp1 = false;

                    workerToAdd.Name = tempName;
                    workerToAdd.Salary = WorkBuilder.Salary * workerToAdd.WorkHours;
                    workerToAdd.Work = WorkBuilder.WorkName;

                    _dataBase.Add(workerToAdd);
                }
            }
        }

        public static void AddBuilder()
        {
            Worker workerToAdd = new Worker();
            Console.Write("Enter worker name: ");
            var tempName = Console.ReadLine();

            bool temp1 = true;
            while (temp1)
            {
                try
                {
                    Console.Write("Enter work hours: ");
                    var tempHours = Console.ReadLine();
                    workerToAdd.WorkHours = Convert.ToInt32(tempHours);
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter a proper value, RedNeck!");
                    Console.WriteLine();
                    continue;
                }

                temp1 = false;

                workerToAdd.Name = tempName;
                workerToAdd.Salary = WorkBuilder.Salary * workerToAdd.WorkHours;
                workerToAdd.Work = WorkBuilder.WorkName;

                _dataBase.Add(workerToAdd);
            }
        }


        public static void AddEngineerFirstTime()
        {
            Worker workerToAdd = new Worker();
            bool temp = true;
            while (temp)
            {
                try
                {
                    Console.Write("Enter Engineer Work Salary: ");
                    var userInput = Console.ReadLine();
                    WorkEngineer.Salary = Convert.ToInt32(userInput);
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Enter a proper value, RedNeck!");
                    continue;
                }

                temp = false;
                Console.Write("Enter worker name: ");
                var tempName = Console.ReadLine();

                bool temp1 = true;
                while (temp1)
                {
                    try
                    {
                        Console.Write("Enter work hours: ");
                        var tempHours = Console.ReadLine();
                        workerToAdd.WorkHours = Convert.ToInt32(tempHours);
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Enter a proper value, RedNeck!");
                        Console.WriteLine();
                        continue;
                    }

                    temp1 = false;

                    workerToAdd.Name = tempName;
                    workerToAdd.Salary = WorkEngineer.Salary * workerToAdd.WorkHours;
                    workerToAdd.Work = WorkEngineer.WorkName;

                    _dataBase.Add(workerToAdd);
                }
            }
        }

        public static void AddEngineer()
        {
            Worker workerToAdd = new Worker();
            Console.Write("Enter worker name: ");
            var tempName = Console.ReadLine();

            bool temp1 = true;
            while (temp1)
            {
                try
                {
                    Console.Write("Enter work hours: ");
                    var tempHours = Console.ReadLine();
                    workerToAdd.WorkHours = Convert.ToInt32(tempHours);
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter a proper value, RedNeck!");
                    Console.WriteLine();
                    continue;
                }

                temp1 = false;

                workerToAdd.Name = tempName;
                workerToAdd.Salary = WorkEngineer.Salary * workerToAdd.WorkHours;
                workerToAdd.Work = WorkEngineer.WorkName;

                _dataBase.Add(workerToAdd);
            }
        }

        public static void AddProgrammerFirstTime()
        {
            Worker workerToAdd = new Worker();
            bool temp = true;
            while (temp)
            {
                try
                {
                    Console.Write("Enter Programmer Work Salary: ");
                    var userInput = Console.ReadLine();
                    WorkProgrammer.Salary = Convert.ToInt32(userInput);
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Enter a proper value, RedNeck!");
                    continue;
                }

                temp = false;
                Console.Write("Enter worker name: ");
                var tempName = Console.ReadLine();

                bool temp1 = true;
                while (temp1)
                {
                    try
                    {
                        Console.Write("Enter work hours: ");
                        var tempHours = Console.ReadLine();
                        workerToAdd.WorkHours = Convert.ToInt32(tempHours);
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Enter a proper value, RedNeck!");
                        Console.WriteLine();
                        continue;
                    }

                    temp1 = false;

                    workerToAdd.Name = tempName;
                    workerToAdd.Salary = WorkProgrammer.Salary * workerToAdd.WorkHours;
                    workerToAdd.Work = WorkProgrammer.WorkName;

                    _dataBase.Add(workerToAdd);
                }
            }
        }

        public static void AddProgrammer()
        {
            Worker workerToAdd = new Worker();
            Console.Write("Enter worker name: ");
            var tempName = Console.ReadLine();

            bool temp1 = true;
            while (temp1)
            {
                try
                {
                    Console.Write("Enter work hours: ");
                    var tempHours = Console.ReadLine();
                    workerToAdd.WorkHours = Convert.ToInt32(tempHours);
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter a proper value, RedNeck!");
                    Console.WriteLine();
                    continue;
                }

                temp1 = false;

                workerToAdd.Name = tempName;
                workerToAdd.Salary = WorkProgrammer.Salary * workerToAdd.WorkHours;
                workerToAdd.Work = WorkProgrammer.WorkName;

                _dataBase.Add(workerToAdd);
            }
        }

        public static void FindByName(string inputName)
        {
            var tempCounter = 0;
            if (_dataBase.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine("DataBase Empty");
                Console.WriteLine();
                return;
            }

            for (int index = 0; index < _dataBase.Count; index++)
            {
                if (_dataBase[index].Name.ToLower() == inputName.ToLower())
                {
                    Console.WriteLine();
                    Console.WriteLine($"Salary for {_dataBase[index].Name} is: {_dataBase[index].Salary.ToString()}");
                    Console.WriteLine();
                    tempCounter++;
                }
            }

            if (tempCounter == 0)
            {
                Console.WriteLine("No Such Worker!");
            }
        }

        public static void TotalInfo()
        {
            var totalSalary = 0;

            if (_dataBase.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine("DataBase Empty");
                Console.WriteLine();
                return;
            }

            for (int index = 0; index < _dataBase.Count; index++)
            {
                Console.WriteLine();
                Console.WriteLine(
                    $"Salary for {_dataBase[index].Name}, who are: {_dataBase[index].Work} is: {_dataBase[index].Salary.ToString()}");
                totalSalary += _dataBase[index].Salary;
            }

            Console.WriteLine();
            Console.WriteLine($"Total Salary Is : {totalSalary}");
            Console.WriteLine();
        }

        public static void InfoAboutWorks()
        {
            if (_dataBase.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine("DataBase Empty");
                Console.WriteLine();
                return;
            }

            Console.WriteLine(
                $"There are 3 works: {WorkBuilder.WorkName}, {WorkEngineer.WorkName}, {WorkProgrammer.WorkName} ");

            Console.WriteLine();
            Console.WriteLine($"{WorkBuilder.WorkName} salary is: {WorkBuilder.Salary.ToString()}");
            Console.WriteLine($"{WorkEngineer.WorkName} salary is: {WorkEngineer.Salary.ToString()}");
            Console.WriteLine($"{WorkProgrammer.WorkName} salary is: {WorkProgrammer.Salary.ToString()}");
            Console.WriteLine();
        }
    }
}