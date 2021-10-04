using System;

namespace _053502_GERCHIK_LAB5_.Entities
{
    public class MainMenu
    {
        private Journal myJournal = new Journal();

        private enum State
        {
            Initiall,
            WorkReady,
            WorkAndWorkerReady
        }

        public void mainMenu(InformationSystem myInformationSystem)
        {
            myInformationSystem.NotifyAboutWorker += message => myJournal.outputEvent(message);
            State state = State.Initiall;

            Console.WriteLine("Hello");
            Console.WriteLine();

            while (true)
            {
                switch (state)
                {
                    case State.Initiall:
                        Console.WriteLine("0 - Exit");
                        Console.WriteLine("1 - Add First Work");
                        Console.Write("Your Choice: ");
                        var userInput = Console.ReadLine();

                        switch (userInput)
                        {
                            case "0":
                                Console.WriteLine();
                                Console.WriteLine("See ya (◕‿◕)");
                                return;
                                break;
                            case "1":
                                Console.WriteLine();
                                myInformationSystem.AddWork();
                                state = State.WorkReady;
                                break;
                            default:
                                Console.WriteLine("Enter Correct, RedNeck (」°ロ°)」");
                                Console.WriteLine();
                                break;
                        }

                        break;

                    case State.WorkReady:
                        Console.WriteLine("0 - Exit");
                        Console.WriteLine("1 - Add Work");
                        Console.WriteLine("2 - Add Worker");
                        Console.Write("Your Choice: ");
                        var userInput1 = Console.ReadLine();

                        switch (userInput1)
                        {
                            case "0":
                                Console.WriteLine();
                                Console.WriteLine("See ya (◕‿◕)");
                                return;
                                break;
                            case "1":
                                Console.WriteLine();
                                myInformationSystem.AddWork();
                                break;
                            case "2":
                                Console.WriteLine();
                                myInformationSystem.AddWorker();
                                state = State.WorkAndWorkerReady;
                                break;
                            default:
                                Console.WriteLine("Enter Correct, RedNeck (」°ロ°)」");
                                Console.WriteLine();
                                break;
                        }

                        break;

                    case State.WorkAndWorkerReady:
                        Console.WriteLine("0 - Exit");
                        Console.WriteLine("1 - Add Work");
                        Console.WriteLine("2 - Add Worker");
                        Console.WriteLine("3 - Info About Available Works");
                        Console.WriteLine("4 - Info About Workers");
                        Console.WriteLine("5 - Employment");
                        Console.WriteLine("6 - Perform Work");
                        Console.WriteLine("7 - Sort Works Dictionary");
                        Console.WriteLine("8 - Best Worker");
                        Console.Write("Your Choice: ");
                        var userInput2 = Console.ReadLine();

                        switch (userInput2)
                        {
                            case "0":
                                Console.WriteLine();
                                Console.WriteLine("See ya (◕‿◕)");
                                return;
                                break;
                            case "1":
                                Console.WriteLine();
                                myInformationSystem.AddWork();
                                break;
                            case "2":
                                Console.WriteLine();
                                myInformationSystem.AddWorker();
                                break;
                            case "3":
                                Console.WriteLine();
                                myInformationSystem.InfoAboutWorks();
                                break;
                            case "4":
                                Console.WriteLine();
                                myInformationSystem.InfoAboutWorkers();
                                break;
                            case "5":
                                Console.WriteLine();
                                myInformationSystem.EmployWorker();
                                break;
                            case "6":
                                Console.WriteLine();
                                myInformationSystem.PerformWork();
                                break;
                            case "7":
                                Console.WriteLine();
                                myInformationSystem.SortWorksDictionary();
                                break;
                            case "8":
                                Console.WriteLine();
                                myInformationSystem.GetBestWorker();
                                break;
                            default:
                                Console.WriteLine("Enter Correct, RedNeck (」°ロ°)」");
                                Console.WriteLine();
                                break;
                        }

                        break;

                    default:
                        Console.WriteLine("Smth Weird");
                        break;
                }
            }
        }
    }
}