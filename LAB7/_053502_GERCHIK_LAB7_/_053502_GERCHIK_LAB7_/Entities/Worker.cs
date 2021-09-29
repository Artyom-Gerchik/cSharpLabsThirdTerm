using System.Collections.Generic;

namespace _053502_GERCHIK_LAB5_.Entities
{
    public class Worker
    {
        public string WorkName;
        public int WorkerSalary { get; set; }

        public string Name;

        public int WorkerWorkHours;

        public List<Work> Works = new List<Work>();
    }
}