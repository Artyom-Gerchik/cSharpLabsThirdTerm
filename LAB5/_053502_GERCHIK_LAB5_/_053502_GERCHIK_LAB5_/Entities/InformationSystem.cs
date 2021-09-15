using System;
using _053502_GERCHIK_LAB5_.Collections;

namespace _053502_GERCHIK_LAB5_.Entities
{
    public class InformationSystem
    {
        private static MyCustomCollection<Worker> _dataBase = new MyCustomCollection<Worker>();
        public static void AddBuilderFirstTime()
        {
            Worker workerToAdd = new Worker(); 
            bool temp = true;
            while (temp)
            {
                try
                {
                    Console.Write("Enter Builder Salary: ");
                    var userInput = Console.ReadLine();
                    WorkBuilder.Salary = Convert.ToInt32(userInput);
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Enter a proper value, RedNeck!");
                    continue;
                }
                temp = false;
                Console.Write("Enter worker name: ");
                var tempName = Console.ReadLine();
                
                
                workerToAdd.Name = tempName;
                workerToAdd.Salary = WorkBuilder.Salary;
                workerToAdd.Work = WorkBuilder.WorkName;
                
                _dataBase.Add(workerToAdd);
                //Console.WriteLine(_dataBase[0].Name);
                //Console.WriteLine(_dataBase[0].Salary);
                
            }

        }
        
        public static void AddBuilder()
        {
            Worker workerToAdd = new Worker(); 
            Console.Write("Enter worker name: ");
            var tempName = Console.ReadLine();
            
            workerToAdd.Name = tempName;
            workerToAdd.Salary = WorkBuilder.Salary;
            workerToAdd.Work = WorkBuilder.WorkName;
                
            _dataBase.Add(workerToAdd);
            
            //Console.WriteLine(_dataBase[1].Salary);
        }
        
        
        public static void AddEngineerFirstTime()
        {
            
        }
        
        public static void AddProgrammerFirstTime()
        {
            
        }
    }
}