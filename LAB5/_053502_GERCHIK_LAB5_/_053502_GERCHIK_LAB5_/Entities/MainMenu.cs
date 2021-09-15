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
                Console.WriteLine("2 - Info By Name");
                Console.WriteLine("3 - Total Info");
                Console.WriteLine("4 - Info About Works");
                Console.WriteLine();
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
                            Console.WriteLine();
                            Console.WriteLine("0 - Back");
                            Console.WriteLine("1 - Add Builder");
                            Console.WriteLine("2 - Add Engineer");
                            Console.WriteLine("3 - Add Programmer");
                            Console.WriteLine();
                            Console.Write("Your Choice: ");
                            string userInput1 = Console.ReadLine();
                            Console.WriteLine();
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
                                case "2":
                                    switch (EngineerState)
                                    {
                                        case WorkStateEngineer.NotInitialized:
                                            InformationSystem.AddEngineerFirstTime();
                                            EngineerState = WorkStateEngineer.Initialized;
                                            break;
                                        case WorkStateEngineer.Initialized:
                                            InformationSystem.AddEngineer();
                                            break;
                                        default:
                                            Console.WriteLine("smth weird");
                                            break;
                                    }

                                    break;
                                case "3":
                                    switch (ProgrammerState)
                                    {
                                        case WorkStateProgrammer.NotInitialized:
                                            InformationSystem.AddProgrammerFirstTime();
                                            ProgrammerState = WorkStateProgrammer.Initialized;
                                            break;
                                        case WorkStateProgrammer.Initialized:
                                            InformationSystem.AddProgrammer();
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
                    case "2":
                        Console.WriteLine();
                        Console.Write("Enter Worker Name: ");
                        var workerName = Console.ReadLine();
                        InformationSystem.FindByName(workerName);
                        break;
                    case "3":
                        Console.WriteLine();
                        InformationSystem.TotalInfo();
                        break;
                    case "4":
                        Console.WriteLine();
                        InformationSystem.InfoAboutWorks();
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Enter correct, RedNeck");
                        break;
                }
            }
        }
    }
}