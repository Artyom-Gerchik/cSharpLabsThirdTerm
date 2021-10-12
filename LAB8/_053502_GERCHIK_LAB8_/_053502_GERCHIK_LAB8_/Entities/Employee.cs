namespace _053502_GERCHIK_LAB8_
{
    public class Employee
    {
        public int Salary { get; set; }
        public bool Vaccinated { get; set; }
        public string Name { get; set; }

        public Employee(int salary, bool vaccinated, string name)
        {
            Salary = salary;
            Vaccinated = vaccinated;
            Name = name;
        }
    }
}