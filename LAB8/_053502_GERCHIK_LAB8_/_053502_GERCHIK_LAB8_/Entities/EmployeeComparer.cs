using System;
using System.Collections.Generic;

namespace _053502_GERCHIK_LAB8_
{
    public class EmployeeComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return String.Compare(x.Name, y.Name);
        }
    }
}