using System;
using System.Collections.Generic;

namespace _053502_GERCHIK_LAB5_.Entities
{
    public class Journal
    {
        private List<string> logs = new List<string>();

        public void outputEvent(string message)
        {
            Console.WriteLine();
            Console.WriteLine(message);
            Console.WriteLine();

            logs.Add(message);
        }

        public void printLogs()
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