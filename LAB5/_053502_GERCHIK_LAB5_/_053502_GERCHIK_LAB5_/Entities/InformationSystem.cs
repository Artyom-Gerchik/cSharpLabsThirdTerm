using System;
using _053502_GERCHIK_LAB5_.Collections;

namespace _053502_GERCHIK_LAB5_.Entities
{
    public class InformationSystem
    {
        private static MyCustomCollection<Worker> _dataBase = new MyCustomCollection<Worker>();

        public delegate void WorkerDelegate(string message);

        public event WorkerDelegate NotifyAboutWorker;

        public delegate void WorkDelegate(string message);

        public event WorkDelegate NotifyAboutPerformedWork;


        public void AddBuilderFirstTime()
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

                workerToAdd.WorkHours = 0;
                workerToAdd.Name = tempName;
                workerToAdd.Salary = WorkBuilder.Salary * workerToAdd.WorkHours;
                workerToAdd.WorkName = WorkBuilder.WorkName;

                _dataBase.Add(workerToAdd);
                NotifyAboutWorker?.Invoke("Builder Added First Time!");
            }
        }

        public void AddBuilder()
        {
            Worker workerToAdd = new Worker();
            Console.Write("Enter worker name: ");
            var tempName = Console.ReadLine();

            workerToAdd.WorkHours = 0;
            workerToAdd.Name = tempName;
            workerToAdd.Salary = WorkBuilder.Salary * workerToAdd.WorkHours;
            workerToAdd.WorkName = WorkBuilder.WorkName;

            _dataBase.Add(workerToAdd);
            NotifyAboutWorker?.Invoke("Builder Added!");
        }


        public void AddEngineerFirstTime()
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

                workerToAdd.WorkHours = 0;
                workerToAdd.Name = tempName;
                workerToAdd.Salary = WorkEngineer.Salary * workerToAdd.WorkHours;
                workerToAdd.WorkName = WorkEngineer.WorkName;

                _dataBase.Add(workerToAdd);
                NotifyAboutWorker?.Invoke("Engineer Added First Time!");
            }
        }

        public void AddEngineer()
        {
            Worker workerToAdd = new Worker();
            Console.Write("Enter worker name: ");
            var tempName = Console.ReadLine();

            workerToAdd.WorkHours = 0;
            workerToAdd.Name = tempName;
            workerToAdd.Salary = WorkEngineer.Salary * workerToAdd.WorkHours;
            workerToAdd.WorkName = WorkEngineer.WorkName;

            _dataBase.Add(workerToAdd);
            NotifyAboutWorker?.Invoke("Engineer Added!");
        }

        public void AddProgrammerFirstTime()
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

                workerToAdd.WorkHours = 0;
                workerToAdd.Name = tempName;
                workerToAdd.Salary = WorkProgrammer.Salary * workerToAdd.WorkHours;
                workerToAdd.WorkName = WorkProgrammer.WorkName;

                _dataBase.Add(workerToAdd);
                NotifyAboutWorker?.Invoke("Programmer Added First Time!");
            }
        }

        public void AddProgrammer()
        {
            Worker workerToAdd = new Worker();
            Console.Write("Enter worker name: ");
            var tempName = Console.ReadLine();

            workerToAdd.WorkHours = 0;
            workerToAdd.Name = tempName;
            workerToAdd.Salary = WorkProgrammer.Salary * workerToAdd.WorkHours;
            workerToAdd.WorkName = WorkProgrammer.WorkName;

            _dataBase.Add(workerToAdd);
            NotifyAboutWorker?.Invoke("Programmer Added!");
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
                    $"Salary for {_dataBase[index].Name}, who are: {_dataBase[index].WorkName} is: {_dataBase[index].Salary.ToString()}");
                totalSalary += _dataBase[index].Salary;
            }

            Console.WriteLine();
            Console.WriteLine($"Total Salary Is : {totalSalary}");
            Console.WriteLine();
        }

        private static bool checkIndex(int index)
        {
            if (index < 0 || index > _dataBase.Count)
            {
                Console.WriteLine("No Such ID");
                return false;
            }

            return true;
        }

        private static bool checkDataBase()
        {
            if (_dataBase.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine("DataBase Empty");
                Console.WriteLine();
                return false;
            }

            return true;
        }

        public static void InfoAboutWorks()
        {
            if (!checkDataBase())
            {
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

        public bool InfoAboutDataBase()
        {
            if (!checkDataBase())
            {
                return false;
            }

            for (int index = 0; index < _dataBase.Count; index++)
            {
                Console.WriteLine($"{(index + 1).ToString()}.");
                Console.WriteLine($"    Name: {_dataBase[index].Name}");
                Console.WriteLine($"    Work: {_dataBase[index].WorkName}");
                Console.WriteLine($"    WorkHours: {_dataBase[index].WorkHours.ToString()}");
                Console.WriteLine($"    Salary: {_dataBase[index].Salary.ToString()}");
            }

            Console.WriteLine();

            return true;
        }

        public void RemoveByIndex()
        {
            string id;
            var index = -5;
            bool temp1 = true;
            while (temp1)
            {
                try
                {
                    Console.Write("Enter ID Which U Wanna Delete: ");
                    id = Console.ReadLine();
                    index = Convert.ToInt32(id);

                    // i'll comment this to show exceptions working on 305,306 strings
                    //if (!checkIndex(index))
                    //{
                    //    Console.WriteLine("Enter a proper value, RedNeck!");
                    //    continue;
                    //}
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter a proper value, RedNeck!");
                    Console.WriteLine();
                    continue;
                }

                temp1 = false;
            }

            string name = _dataBase[index - 1]?.Name;
            _dataBase.Remove(_dataBase[index - 1]);
            if (name != null)
            {
                NotifyAboutWorker?.Invoke($"Worker {name} Removed!");
            }
        }

        public void PerformWork()
        {
            string hours;
            var hoursAsInt = 0;

            string id;
            var index = 0;

            bool temp1 = true;
            while (temp1)
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter ID Who Will Work: ");
                    id = Console.ReadLine();
                    index = Convert.ToInt32(id);

                    if (!checkIndex(index))
                    {
                        continue;
                    }

                    Console.WriteLine("Enter Work Hours: ");
                    hours = Console.ReadLine();
                    hoursAsInt = Convert.ToInt32(hours);

                    if (hoursAsInt < 0)
                    {
                        Console.WriteLine("Works Hours Cannot Be < 0");
                        continue;
                    }

                    _dataBase[index - 1].WorkHours = hoursAsInt;

                    if (_dataBase[index - 1].WorkName == WorkBuilder.WorkName)
                    {
                        _dataBase[index - 1].Salary = WorkBuilder.Salary * _dataBase[index - 1].WorkHours;
                    }
                    else if (_dataBase[index - 1].WorkName == WorkEngineer.WorkName)
                    {
                        _dataBase[index - 1].Salary = WorkEngineer.Salary * _dataBase[index - 1].WorkHours;
                    }
                    else if (_dataBase[index - 1].WorkName == WorkProgrammer.WorkName)
                    {
                        _dataBase[index - 1].Salary = WorkProgrammer.Salary * _dataBase[index - 1].WorkHours;
                    }
                    else
                    {
                        throw new MyException("smth Weird");
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter a proper value, RedNeck!");
                    Console.WriteLine();
                    continue;
                }
                catch (MyException ex)
                {
                    continue;
                }

                temp1 = false;
            }

            NotifyAboutPerformedWork?.Invoke($"Work Performed For {_dataBase[index - 1].Name}, Hours: {hoursAsInt}");
        }
    }
}