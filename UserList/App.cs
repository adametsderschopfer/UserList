using System;
using System.Collections.Generic;

namespace UserList
{
    public enum MenuType : int
    {
        MAIN_MENU = 0,
        GET_USERS = 1,
        CREATE_USER = 2,
        REMOVE_USER = 3,
    }

    public class App
    {
        private List<User> _users = new List<User>();

        private bool _isRunning = false;
        private MenuType _currentMenuType = 0;

        public void Run()
        {
            _isRunning = true;

            while (_isRunning)
            {
                Console.WriteLine("[USER LIST APPLICATION]");
                Console.WriteLine("");

                switch (_currentMenuType)
                {
                    case MenuType.MAIN_MENU:
                    {
                        Console.WriteLine("Choose command:");
                        Console.WriteLine("\t[C] => Create user.");
                        Console.WriteLine("\t[R] => Remove user.");
                        Console.WriteLine("\t[G] => Get users.");
                        Console.WriteLine("\t[H] => Go to Home.");
                        Console.WriteLine("");
                        Console.WriteLine("\t[X] => Exit.");

                        break;
                    }
                        ;

                    case MenuType.GET_USERS:
                    {
                        Console.WriteLine($"Users ({_users.Count})");

                        if (_users.Count == 0)
                        {
                            Console.WriteLine("-=> Users is empty <=-");
                            Console.WriteLine();
                            Console.WriteLine("\t[H] => Go to Home.");
                            break;
                        }
                        else
                        {
                            foreach (var user in _users)
                            {
                                user.PrintMiniInfo();
                            }
                        }

                        break;
                    }

                    case MenuType.CREATE_USER:
                    {
                        Console.WriteLine("FirstName: ");
                        var uFirstName = Console.ReadLine();

                        Console.WriteLine("LastName: ");
                        var uLastName = Console.ReadLine();

                        Console.WriteLine("Age: ");
                        var uAge = Console.ReadLine();

                        Console.WriteLine("Place: ");
                        var uPlace = Console.ReadLine();

                        Console.WriteLine("Company: ");
                        var uCompany = Console.ReadLine();

                        var newUser = new User(
                            uFirstName,
                            uLastName,
                            uAge,
                            uPlace,
                            uCompany
                        );

                        _users.Add(newUser);
                        _currentMenuType = MenuType.MAIN_MENU;
                        break;
                    }

                    case MenuType.REMOVE_USER:
                    {
                        break;
                    }

                    default:
                    {
                        break;
                    }
                }

                var currentKey = Console.ReadKey();

                switch (currentKey.Key)
                {
                    case ConsoleKey.X:
                    {
                        _isRunning = false;

                        Console.Clear();
                        Console.WriteLine("UserList application is stopped. Users is cleared :(");

                        break;
                    }

                    case ConsoleKey.G:
                    {
                        _currentMenuType = MenuType.GET_USERS;
                        break;
                    }

                    case ConsoleKey.C:
                    {
                        _currentMenuType = MenuType.CREATE_USER;
                        break;
                    }

                    case ConsoleKey.H:
                    {
                        _currentMenuType = MenuType.MAIN_MENU;
                        break;
                    }

                    default:
                    {
                        break;
                    }
                }

                if (_isRunning)
                {
                    Console.Clear();
                }
            }
        }

        public static App Create()
        {
            var application = new App();
            return application;
        }
    }
}