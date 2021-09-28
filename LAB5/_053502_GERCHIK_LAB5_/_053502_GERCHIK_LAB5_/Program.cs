using System;
using _053502_GERCHIK_LAB5_.Collections;
using _053502_GERCHIK_LAB5_.Entities;

namespace _053502_GERCHIK_LAB5_
{
    class Program
    {
        private static MainMenu _mainMenu = new MainMenu();

        private static void Main()
        {
            InformationSystem infSys = new InformationSystem();
            infSys.NotifyAboutPerformedWork += (message) => Console.WriteLine(message);

            _mainMenu.mainMenu(infSys);
        }
    }
}