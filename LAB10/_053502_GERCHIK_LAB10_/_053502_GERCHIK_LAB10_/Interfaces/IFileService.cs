using System.Collections.Generic;

namespace _053502_GERCHIK_LAB10_.Interfaces
{
    public interface IFileService<T> where T : class
    {
        IEnumerable<T> ReadFile(string fileName);
        void SaveData(IEnumerable<T> data, string fileName);
    }
}