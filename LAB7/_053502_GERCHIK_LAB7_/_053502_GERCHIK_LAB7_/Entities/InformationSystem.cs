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

        public void Initiall()
        {
            worksDictionary.Add("Builder", new Work("Builder", 1000));
            worksDictionary.Add("Builder1", new Work("Builder1", 1500));
            worksDictionary.Add("Builder2", new Work("Builder2", 2000));

            Worker workerToAdd = new Worker();

            workerToAdd.Name = "Vasya";
            workerToAdd.Works.Add(worksDictionary.ElementAt(0).Value);

            _dataBase.Add(workerToAdd);
        }

        private int GetWorkerId()
        {
            bool temp = true;
            int workerId = -1;
            while (temp)
            {
                try
                {
                    Console.Write("Enter Worker ID: ");
                    var userInput = Console.ReadLine();
                    workerId = Convert.ToInt32(userInput);

                    if (workerId > _dataBase.Count || workerId < 0)
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

            return workerId - 1;
        }

        private int GetWorkId()
        {
            bool temp = true;
            int workId = -1;
            while (temp)
            {
                try
                {
                    Console.Write("Enter Work ID: ");
                    var userInput = Console.ReadLine();
                    workId = Convert.ToInt32(userInput);

                    if (workId > worksDictionary.Count || workId < 0)
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

            return workId - 1;
        }

        private int GetWorkIdForThatWorker(Worker worker)
        {
            bool temp = true;
            int workId = -1;
            while (temp)
            {
                try
                {
                    Console.WriteLine($"Enter Work ID On Which {worker.Name} Will Work: ");
                    Console.WriteLine();
                    Console.WriteLine($"{worker.Name} Works: ");
                    for (int workIndex = 0; workIndex < worker.Works.Count; workIndex++)
                    {
                        Console.WriteLine($"{(workIndex + 1).ToString()}.{worker.Works[workIndex].WorkName} ");
                    }

                    Console.WriteLine();
                    Console.Write("Your Choice: ");
                    var userInput = Console.ReadLine();
                    workId = Convert.ToInt32(userInput);

                    if (workId > worker.Works.Count || workId < 0)
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

            return workId - 1;
        }

        public void AddWork()
        {
            string workName = null;
            double workSalary = 0;

            bool temp = true;

            while (temp)
            {
                try
                {
                    Console.Write("Enter Work Name: ");
                    workName = Console.ReadLine();

                    Console.Write($"Enter {workName} Salary: ");
                    var userInput = Console.ReadLine();
                    workSalary = Convert.ToDouble(userInput);

                    Work workToAdd = new Work(workName, workSalary);
                    worksDictionary.Add(workToAdd.WorkName, workToAdd);

                    Console.WriteLine();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter a proper value, RedNeck!");
                    continue;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Such Work Exist Yet!");
                    continue;
                }

                temp = false;
            }
        }

        public void AddWorker()
        {
            Worker workerToAdd = new Worker();

            Console.Write("Enter Worker Name: ");
            var workerName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"Choose Work For {workerName}: ");
            InfoAboutWorks();

            bool temp = true;
            string userInput;
            int workId = GetWorkId();

            workerToAdd.Name = workerName;
            workerToAdd.Works.Add(worksDictionary.ElementAt(workId).Value);

            _dataBase.Add(workerToAdd);
            NotifyAboutWorker?.Invoke($"{worksDictionary.ElementAt(workId).Key} Added!");
            Console.WriteLine();
        }

        public void InfoAboutWorks()
        {
            Console.WriteLine();
            Console.WriteLine("----------WORKS----------");
            Console.WriteLine();

            Console.WriteLine($"We Have {worksDictionary.Count.ToString()} Works Yet:");
            Console.WriteLine();

            for (int index = 0; index < worksDictionary.Count; index++)
            {
                Console.WriteLine(
                    $"{(index + 1).ToString()}. {worksDictionary.ElementAt(index).Key}.\tSalary: {worksDictionary.ElementAt(index).Value.Salary.ToString()}");
            }

            Console.WriteLine();
            Console.WriteLine("----------WORKS----------");
            Console.WriteLine();
        }

        public void InfoAboutWorkers()
        {
            Console.WriteLine();
            Console.WriteLine("---------WORKERS---------");
            Console.WriteLine();

            Console.WriteLine($"We Have {_dataBase.Count.ToString()} Workers Yet: ");
            Console.WriteLine();

            double totalSalary = 0;

            for (int index = 0; index < _dataBase.Count; index++)
            {
                Console.WriteLine($"{(index + 1).ToString()}.");
                Console.WriteLine($"Name: {_dataBase[index].Name}");
                Console.WriteLine("Works: ");

                for (int workIndex = 0; workIndex < _dataBase[index].Works.Count; workIndex++)
                {
                    Console.WriteLine($"{(workIndex + 1).ToString()}. {_dataBase[index].Works[workIndex].WorkName} ");
                }

                Console.WriteLine("Work Hours: ");

                for (int workHoursIndex = 0; workHoursIndex < _dataBase[index].WorkHours.Count; workHoursIndex++)
                {
                    Console.WriteLine(
                        $"{(workHoursIndex + 1).ToString()}. {_dataBase[index].WorkHours.ElementAt(workHoursIndex).Key.WorkName}: {_dataBase[index].WorkHours.ElementAt(workHoursIndex).Value.ToString()}");
                }

                Console.WriteLine($"Salary: {_dataBase[index].WorkerSalary.ToString()}");
                totalSalary += _dataBase[index].WorkerSalary;
                Console.WriteLine();
            }

            Console.WriteLine($"Total Salary: {totalSalary}");

            Console.WriteLine();
            Console.WriteLine("---------WORKERS---------");
            Console.WriteLine();
        }

        public void EmployWorker()
        {
            InfoAboutWorkers();
            InfoAboutWorks();

            int workerId = GetWorkerId();
            int workId = GetWorkId();

            if (_dataBase[workerId].Works.Count == worksDictionary.Count)
            {
                Console.WriteLine($"{_dataBase[workerId].Name} Employed To All Available Works.");
                return;
            }
            else if (_dataBase[workerId].Works.Contains(worksDictionary.ElementAt(workId).Value))
            {
                Console.WriteLine("This Worker Already Employed To This Work!");
                return;
            }
            else
            {
                _dataBase[workerId].Works.Add(worksDictionary.ElementAt(workId).Value);
                Console.WriteLine("Employed!");
            }

            Console.WriteLine();
        }

        public void PerformWork()
        {
            InfoAboutWorkers();
            int workerId = GetWorkerId();
            int workId = GetWorkIdForThatWorker(_dataBase[workerId]);

            bool temp = true;
            int workHours = -1;
            while (temp)
            {
                try
                {
                    Console.Write("Enter Work Hours: ");
                    var userInput = Console.ReadLine();
                    workHours = Convert.ToInt32(userInput);

                    if (workHours < 0)
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

            int tempHourstoAdd = workHours;
            try
            {
                _dataBase[workerId].WorkHours.Add(_dataBase[workerId].Works[workId], workHours);
            }
            catch (ArgumentException)
            {
                _dataBase[workerId].WorkHours[_dataBase[workerId].Works[workId]] += tempHourstoAdd;
            }

            //_dataBase[workerId].SalaryByWork.Add(_dataBase[workerId].Works[workId],
            //    _dataBase[workerId].Works[workId].Salary * _dataBase[workerId].WorkHours.ElementAt(workId).Value);

            _dataBase[workerId].WorkerSalary += _dataBase[workerId].Works[workId].Salary *
                                                _dataBase[workerId].WorkHours.ElementAt(workId).Value;

            NotifyAboutPerformedWork?.Invoke(
                $"Work For {_dataBase[workerId].Name} Performed. As {_dataBase[workerId].Works[workId].WorkName}, For {workHours} Hours. ");
            Console.WriteLine();
        }

        public void SortWorksDictionary()
        {
            Console.WriteLine("Before sort: ");
            InfoAboutWorks();
            Console.WriteLine();

            var orderedDictionary = worksDictionary.OrderBy(x => x.Value.Salary).ToDictionary(x => x.Key, x => x.Value);
            worksDictionary = orderedDictionary;

            Console.WriteLine("After sort: ");
            InfoAboutWorks();
            Console.WriteLine();
        }

        public void GetBestWorker()
        {
            var orderedWorkers = _dataBase.OrderBy(x => x.WorkerSalary).ToList();
            Console.WriteLine(
                $"Best Worker Is: {orderedWorkers[orderedWorkers.Count - 1].Name}, Salary Is: {orderedWorkers[orderedWorkers.Count - 1].WorkerSalary.ToString()}");
            Console.WriteLine();
        }

        public void HowMuchWorkersHaveGreaterSalary()
        {
            List<double> workersSalaries = new List<double>();

            for (int index = 0; index < _dataBase.Count; index++)
            {
                workersSalaries.Add(_dataBase[index].WorkerSalary);
            }

            bool temp = true;
            double salaryToSort = -1;
            while (temp)
            {
                try
                {
                    Console.Write("Enter Salary To Sort: ");
                    var userInput = Console.ReadLine();
                    salaryToSort = Convert.ToDouble(userInput);

                    if (salaryToSort < 0)
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

            double howMuchWorkers = workersSalaries.Aggregate(0, (total, next) =>
                next > salaryToSort ? total + 1 : total);

            Console.WriteLine();
            Console.WriteLine($"{howMuchWorkers.ToString()} Workers Have Salary > {salaryToSort.ToString()}");
            Console.WriteLine();
        }

        public void GroupBySalaries()
        {
            InfoAboutWorkers();

            Worker testWorker = _dataBase[GetWorkerId()];

            testWorker.GroupByMethod(testWorker);
        }
    }
}