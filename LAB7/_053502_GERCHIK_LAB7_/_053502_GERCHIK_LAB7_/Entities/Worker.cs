using System;
using System.Collections.Generic;
using System.Linq;

namespace _053502_GERCHIK_LAB5_.Entities
{
    public class Worker
    {
        public double WorkerSalary { get; set; }

        public string Name;

        public Dictionary<Work, int> WorkHours = new Dictionary<Work, int>();

        //public Dictionary<Work, double> SalaryByWork = new Dictionary<Work, double>();

        public List<Work> Works = new List<Work>();

        public void GroupByMethod(Worker worker)
        {
            var test = worker.Works.GroupBy(w => w.WorkName);
            var indexForWork = -1;
            double WorkSalary = -1;

            foreach (var q in test)
            {
                for (int index = 0; index < worker.Works.Count; index++)
                {
                    if (worker.Works[index].WorkName == q.Key)
                    {
                        indexForWork = index;
                        WorkSalary = worker.Works[index].Salary;
                    }
                }

                Console.WriteLine($"For {worker.Name}: ");
                Console.WriteLine(
                    $"{q.Key}: {(worker.WorkHours.ElementAt(indexForWork).Value * WorkSalary).ToString()}");
                Console.WriteLine();
            }
        }
    }
}