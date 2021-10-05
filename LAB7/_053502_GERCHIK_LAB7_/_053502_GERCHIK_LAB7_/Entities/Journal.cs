using System;
using System.Collections.Generic;

namespace _053502_GERCHIK_LAB5_.Entities
{
    public class Journal
    {
        private List<string> logs = new List<string>();

        public void OutputEvent(string message)
        {
            Console.WriteLine();
            Console.WriteLine(message);
            Console.WriteLine();

            logs.Add(message);
        }

        public void PrintLogs()
        {
            Console.WriteLine("---------------LOGS---------------");
            
            for (int index = 0; index < logs.Count; index++)
            {
                Console.WriteLine(logs[index]);
                Console.WriteLine();
            }

            Console.WriteLine("---------------LOGS---------------");
        }
    }
}