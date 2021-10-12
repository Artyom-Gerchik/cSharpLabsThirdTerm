using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _053502_GERCHIK_LAB8_
{
    public class FileService : IFileService
    {
        public void cleanUpDirectory()
        {
            Directory.EnumerateFiles(@"/Users/lnxd/Desktop/BSUIR/THIRD TERM/ISP/LABS/LAB8/", "*.dat").ToList()
                .ForEach(x => File.Delete(x));
        }

        public IEnumerable<Employee> ReadFile(string fileName)
        {
            string path = $@"/Users/lnxd/Desktop/BSUIR/THIRD TERM/ISP/LABS/LAB8/{fileName}.dat";
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                while (reader.PeekChar() > -1)
                {
                    string name = reader.ReadString();
                    bool vaccinated = reader.ReadBoolean();
                    int salary = reader.ReadInt32();

                    yield return new Employee(salary, vaccinated, name);
                }

                reader.Close();
            }
        }

        public void SaveData(IEnumerable<Employee> data, string fileName)
        {
            string path = $@"/Users/lnxd/Desktop/BSUIR/THIRD TERM/ISP/LABS/LAB8/{fileName}.dat";
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                foreach (Employee e in data)
                {
                    writer.Write(e.Name);
                    writer.Write(e.Vaccinated);
                    writer.Write(e.Salary);
                }

                writer.Close();
            }
        }
    }
}