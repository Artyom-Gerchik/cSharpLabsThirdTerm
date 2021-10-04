using System;
using System.Collections.Generic;

namespace _053502_GERCHIK_LAB5_.Entities
{
    public class Worker
    {
        public string WorkName;
        public double WorkerSalary { get; set; }

        public string Name;

        public int WorkerWorkHours;

        public Dictionary<Work, int> workHours = new Dictionary<Work, int>(); 

        public List<Work> Works = new List<Work>();
    }
}