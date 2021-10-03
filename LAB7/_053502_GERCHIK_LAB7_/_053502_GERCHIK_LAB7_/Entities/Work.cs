namespace _053502_GERCHIK_LAB5_.Entities
{
    public class Work
    {
        public double Salary { get; set; }

        public string WorkName;
        public Work(string name, double salary)
        {
            Salary = salary;
            WorkName = name;
        }

        
    }
}