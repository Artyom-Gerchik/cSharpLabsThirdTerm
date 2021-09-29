using System;

namespace _053502_GERCHIK_LAB5_.Entities
{
    public class MainMenu
    {
        private Journal myJournal = new Journal();

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


        public void mainMenu(InformationSystem myInformationSystem)
        {
            myInformationSystem.NotifyAboutWorker += message => myJournal.outputEvent(message);

            Console.WriteLine("Hello");
            Console.WriteLine();

            WorkStateBuilder BuilderState = WorkStateBuilder.NotInitialized;
            WorkStateEngineer EngineerState = WorkStateEngineer.NotInitialized;
            WorkStateProgrammer ProgrammerState = WorkStateProgrammer.NotInitialized;

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("0 - Exit");
                Console.WriteLine("1 - Add Worker");
                Console.WriteLine("2 - Perform Work");
                Console.WriteLine("3 - Info By Name");
                Console.WriteLine("4 - Total Info");
                Console.WriteLine("5 - Info About Works");
                Console.WriteLine("6 - Info About DataBase");
                Console.WriteLine("7 - Delete Worker");
                Console.WriteLine("8 - Logs");
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
                                            myInformationSystem.AddBuilderFirstTime();
                                            BuilderState = WorkStateBuilder.Initialized;
                                            break;
                                        case WorkStateBuilder.Initialized:
                                            myInformationSystem.AddBuilder();
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
                                            myInformationSystem.AddEngineerFirstTime();
                                            EngineerState = WorkStateEngineer.Initialized;
                                            break;
                                        case WorkStateEngineer.Initialized:
                                            myInformationSystem.AddEngineer();
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
                                            myInformationSystem.AddProgrammerFirstTime();
                                            ProgrammerState = WorkStateProgrammer.Initialized;
                                            break;
                                        case WorkStateProgrammer.Initialized:
                                            myInformationSystem.AddProgrammer();
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
                        if (myInformationSystem.InfoAboutDataBase())
                        {
                            myInformationSystem.PerformWork();
                        }

                        break;
                    case "3":
                        Console.WriteLine();
                        Console.Write("Enter Worker Name: ");
                        var workerName = Console.ReadLine();
                        myInformationSystem.FindByName(workerName);
                        break;
                    case "4":
                        Console.WriteLine();
                        myInformationSystem.TotalInfo();
                        break;
                    case "5":
                        Console.WriteLine();
                        myInformationSystem.InfoAboutWorks();
                        break;
                    case "6":
                        Console.WriteLine();
                        myInformationSystem.InfoAboutDataBase();
                        break;
                    case "7":
                        Console.WriteLine();
                        if (myInformationSystem.InfoAboutDataBase())
                        {
                            myInformationSystem.RemoveByIndex();
                        }

                        break;
                    case "8":
                        myJournal.printLogs();
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