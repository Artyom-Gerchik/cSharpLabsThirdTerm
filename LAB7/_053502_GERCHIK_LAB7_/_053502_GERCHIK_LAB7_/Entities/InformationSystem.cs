using System;
using System.Collections.Generic;
using System.Linq;

namespace _053502_GERCHIK_LAB5_.Entities
{
    public class InformationSystem
    {
        private List<Worker> _dataBase = new List<Worker>();

        private Dictionary<string, Work> worksDictionary = new Dictionary<string, Work>();

        public delegate void WorkerDelegate(string message);

        public event WorkerDelegate NotifyAboutWorker;

        public delegate void WorkDelegate(string message);

        public event WorkDelegate NotifyAboutPerformedWork;

        public void AddWork()
        {
            Console.Write("Enter a Work Name: ");
            string workName = Console.ReadLine();
            double workSalary = 0;

            bool temp = true;

            while (temp)
            {
                try
                {
                    Console.Write($"Enter {workName} Salary: ");
                    var userInput = Console.ReadLine();
                    workSalary = Convert.ToDouble(userInput);
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Enter a proper value, RedNeck!");
                    continue;
                }

                temp = false;
            }

            Work workToAdd = new Work(workName, workSalary);
            worksDictionary.Add(workToAdd.WorkName, workToAdd);

        }

        public void AddWorker()
        {
            Worker workerToAdd = new Worker();

            Console.Write("Enter Worker Name: ");
            var workerName = Console.ReadLine();

            Console.WriteLine("Choose Work For Worker: ");
            for (int index = 0; index < worksDictionary.Count; index++)
            {
                Console.WriteLine($"{index + 1}. {worksDictionary.ElementAt(index).Key} ");
            }

            bool temp = true;
            string userInput;
            int ID = -1;
            while (temp)
            {
                try
                {
                    Console.Write("Enter Work ID: ");
                    userInput = Console.ReadLine();
                    ID = Convert.ToInt32(userInput);

                    if(ID > worksDictionary.Count || ID < 0)
                    {
                        Console.WriteLine("Enter a proper value, RedNeck!");
                        continue;
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Enter a proper value, RedNeck!");
                    continue;
                }

                temp = false;
            }

        }

        public void AddBuilderFirstTime()
        {
            Worker workerToAdd = new Worker();
            string userInput;
            double test = 0;
            bool temp = true;

            while (temp)
            {
                try
                {
                    Console.Write("Enter Builder Work Salary: ");
                    userInput = Console.ReadLine();
                    WorkBuilder.Salary = Convert.ToInt32(userInput);
                    test = Convert.ToDouble(userInput);
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Enter a proper value, RedNeck!");
                    continue;
                }

                temp = false;
                Console.Write("Enter worker name: ");
                var tempName = Console.ReadLine();

                workerToAdd.WorkerWorkHours = 0;
                workerToAdd.Name = tempName;
                workerToAdd.WorkerSalary = WorkBuilder.Salary * workerToAdd.WorkerWorkHours;
                workerToAdd.WorkName = WorkBuilder.WorkName;
                workerToAdd.Works.Add(new Work("Work Builder", test));

                _dataBase.Add(workerToAdd);
                NotifyAboutWorker?.Invoke("Builder Added First Time!");
            }
        }

        public void AddBuilder()
        {
            Worker workerToAdd = new Worker();
            Console.Write("Enter worker name: ");
            var tempName = Console.ReadLine();

            workerToAdd.WorkerWorkHours = 0;
            workerToAdd.Name = tempName;
            workerToAdd.WorkerSalary = WorkBuilder.Salary * workerToAdd.WorkerWorkHours;
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

                workerToAdd.WorkerWorkHours = 0;
                workerToAdd.Name = tempName;
                workerToAdd.WorkerSalary = WorkEngineer.Salary * workerToAdd.WorkerWorkHours;
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

            workerToAdd.WorkerWorkHours = 0;
            workerToAdd.Name = tempName;
            workerToAdd.WorkerSalary = WorkEngineer.Salary * workerToAdd.WorkerWorkHours;
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

                workerToAdd.WorkerWorkHours = 0;
                workerToAdd.Name = tempName;
                workerToAdd.WorkerSalary = WorkProgrammer.Salary * workerToAdd.WorkerWorkHours;
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

            workerToAdd.WorkerWorkHours = 0;
            workerToAdd.Name = tempName;
            workerToAdd.WorkerSalary = WorkProgrammer.Salary * workerToAdd.WorkerWorkHours;
            workerToAdd.WorkName = WorkProgrammer.WorkName;

            _dataBase.Add(workerToAdd);
            NotifyAboutWorker?.Invoke("Programmer Added!");
        }

        public void FindByName()
        {
            Console.Write("Enter Worker Name: ");
            var workerName = Console.ReadLine();

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
                if (_dataBase[index].Name.ToLower() == workerName.ToLower())
                {
                    Console.WriteLine();
                    Console.WriteLine(
                        $"Salary for {_dataBase[index].Name} is: {_dataBase[index].WorkerSalary.ToString()}");
                    Console.WriteLine();
                    tempCounter++;
                }
            }

            if (tempCounter == 0)
            {
                Console.WriteLine("No Such Worker!");
            }
        }

        public void TotalInfo()
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
                    $"Salary for {_dataBase[index].Name}, who are: {_dataBase[index].WorkName} is: {_dataBase[index].WorkerSalary.ToString()}");
                totalSalary += _dataBase[index].WorkerSalary;
            }

            Console.WriteLine();
            Console.WriteLine($"Total Salary Is : {totalSalary}");
            Console.WriteLine();
        }

        private bool checkIndex(int index)
        {
            if (index < 0 || index > _dataBase.Count)
            {
                Console.WriteLine("No Such ID");
                return false;
            }

            return true;
        }

        private bool checkDataBase()
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

        public void InfoAboutWorks()
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
                Console.WriteLine($"    WorkHours: {_dataBase[index].WorkerWorkHours.ToString()}");
                Console.WriteLine($"    Salary: {_dataBase[index].WorkerSalary.ToString()}");
            }

            Console.WriteLine();

            return true;
        }

        public void RemoveByIndex()
        {
            string id;
            var index = -5;
            string name = null;

            bool temp1 = true;
            while (temp1)
            {
                try
                {
                    Console.Write("Enter ID Which U Wanna Delete: ");
                    id = Console.ReadLine();
                    index = Convert.ToInt32(id);

                    if (index > 0 && index <= _dataBase.Count)
                    {
                        name = _dataBase[index - 1]?.Name; // need test for index cause dropping in list.cs
                        _dataBase.Remove(_dataBase[index - 1]);
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("No Such ID");
                        Console.WriteLine();
                        continue;
                    }
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

                    _dataBase[index - 1].WorkerWorkHours = hoursAsInt;

                    if (_dataBase[index - 1].WorkName == WorkBuilder.WorkName)
                    {
                        _dataBase[index - 1].WorkerSalary = WorkBuilder.Salary * _dataBase[index - 1].WorkerWorkHours;
                    }
                    else if (_dataBase[index - 1].WorkName == WorkEngineer.WorkName)
                    {
                        _dataBase[index - 1].WorkerSalary = WorkEngineer.Salary * _dataBase[index - 1].WorkerWorkHours;
                    }
                    else if (_dataBase[index - 1].WorkName == WorkProgrammer.WorkName)
                    {
                        _dataBase[index - 1].WorkerSalary =
                            WorkProgrammer.Salary * _dataBase[index - 1].WorkerWorkHours;
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

        public void test()
        {
            Console.WriteLine(_dataBase[0].Works[0].WorkName);
        }
    }
}