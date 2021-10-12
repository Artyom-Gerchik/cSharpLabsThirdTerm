using System.Collections.Generic;

namespace _053502_GERCHIK_LAB8_
{
    public interface IFileService
    {
        IEnumerable<Employee> ReadFile(string fileName);
        void SaveData(IEnumerable<Employee> data, string fileName);
    }
}