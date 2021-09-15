using System;
using System.Diagnostics;

namespace _053502_GERCHIK_LAB5_.Entities
{
    public class MainMenu
    {
        private enum WorkStateBuilder
        {
            NotInitialized,
            Initialized
        }
        
        private enum WorkStateEngineer
        {
            NotInitialized,
            Initialized
        }
        
        private enum WorkStateProgrammer
        {
            NotInitialized,
            Initialized
        }
        
        
        public static void mainMenu()
        {
            Console.WriteLine("Hello");
            Console.WriteLine();
            
            WorkStateBuilder BuilderState = WorkStateBuilder.NotInitialized;
            WorkStateEngineer EngineerState = WorkStateEngineer.NotInitialized;
            WorkStateProgrammer ProgrammerState = WorkStateProgrammer.NotInitialized;
            
            while (true)
            {
                Console.WriteLine("0 - Exit");
                Console.WriteLine("1 - Add Worker");
                Console.Write("Your choice: ");
                string userInput = Console.ReadLine();
                Console.WriteLine();
                switch (userInput)
                {
                    case "0":
                        Console.WriteLine("See ya");
                        return;
                        break;
                    case "1":
                        bool temp = true;
                        while (temp)
                        {
                            Console.WriteLine("0 - Back");
                            Console.WriteLine("1 - Add Builder");
                            Console.Write("Your Choice: ");
                            string userInput1 = Console.ReadLine();
                            switch (userInput1)
                            {
                                case "0":
                                    temp = false;
                                break;
                                case "1":
                                    switch (BuilderState)
                                    {
                                        case WorkStateBuilder.NotInitialized:
                                            InformationSystem.AddBuilderFirstTime();
                                            BuilderState = WorkStateBuilder.Initialized;
                                            break;
                                        case WorkStateBuilder.Initialized:
                                            InformationSystem.AddBuilder();
                                            break;
                                        default:
                                            Console.WriteLine("smth weird");
                                            break;
                                    }
                                    
                                    break;
                                default:
                                    Console.WriteLine("Enter correct, RedNeck");
                                    break;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Enter correct, RedNeck");
                        break;
                }
            }
        }
    }
}