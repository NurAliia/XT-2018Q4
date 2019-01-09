// <copyright file="ConsoleApp.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task7.ConsolePL
{
    using System;
    using Epam.Task7.BLL.Interface;
    using Epam.Task7.Common;
    using Epam.Task7.Entities;

    /// <summary>
    ///  This class performs app's functions.
    /// </summary>
    public class ConsoleApp
    {
        /// <summary>
        /// Declare variable awardLogic
        /// </summary>
        private IAwardLogic awardLogic;

        /// <summary>
        /// Declare variable userLogic
        /// </summary>
        private IUserLogic userLogic;

        /// <summary>
        /// Start console application.
        /// </summary>
        public void Start()
        {
            this.awardLogic = DependencyResolver.AwardLogic;
            this.userLogic = DependencyResolver.UserLogic;

            Console.Clear();
            Console.WriteLine("Main menu: \n");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Update");
            Console.WriteLine("3. Delete");
            Console.WriteLine("4. Show");
            Console.WriteLine("5. Exit");

            Console.Write("\nChoose menu item ");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    {
                        this.Add();
                        break;
                    }

                case ConsoleKey.D2:
                    {
                        this.Update();
                        break;
                    }

                case ConsoleKey.D3:
                    {
                        this.Delete();
                        break;
                    }

                case ConsoleKey.D4:
                    {
                        this.Show();
                        break;
                    }

                case ConsoleKey.D5:
                    {
                        Console.WriteLine("\nEXIT\n");
                        this.Terminate();
                        return;
                    }

                default:
                    return;
            }
        }

        /// <summary>
        /// Menu action - add
        /// </summary>
        private void Add()
        {
            Console.Clear();
            Console.WriteLine("Add menu: \n");
            Console.WriteLine("1. Add new user");
            Console.WriteLine("2. Add new award to user");
            Console.WriteLine("3. To main menu");

            Console.Write("\nChoose menu item ");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    {
                        Console.WriteLine("\n");
                        Console.Write("Enter user's name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter user's lastname: ");
                        string lastname = Console.ReadLine();
                        Console.Write("Enter user's date of birth yyyy.mm.dd: ");
                        DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());

                        try
                        {
                            this.userLogic.Add(new User(name, lastname, dateOfBirth));
                        }
                        catch (ArgumentNullException nullEx)
                        {
                            Console.WriteLine($"\n{nullEx.Message}");
                            Console.WriteLine("Press any key for continue");
                            Console.ReadKey();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"\n{ex.Message}");
                            Console.WriteLine("Press any key for continue");
                            Console.ReadKey();
                        }

                        this.Start();
                        break;
                    }

                case ConsoleKey.D2:
                    {
                        Console.WriteLine("\n");

                        Console.Write("Enter user's Id: ");
                        int idUser = int.Parse(Console.ReadLine());
                        Console.Write("Enter award's title: ");
                        string title = Console.ReadLine();

                        try
                        {
                            this.awardLogic.Add(idUser, title);
                        }
                        catch (ArgumentNullException nullEx)
                        {
                            Console.WriteLine($"\n{nullEx.Message} \n ");
                            Console.WriteLine("Press any key for continue");
                            Console.ReadKey();
                        }

                        this.Add();
                        break;
                    }

                case ConsoleKey.D3:
                    {
                        this.Start();
                        break;
                    }

                default:
                    return;
            }
        }

        /// <summary>
        /// Menu action - update
        /// </summary>
        private void Update()
        {
            Console.Clear();
            Console.WriteLine("Update menu: \n");

            Console.WriteLine("1. Update user");
            Console.WriteLine("2. Update award");
            Console.WriteLine("3. To main menu");

            Console.Write("\nChoose menu item ");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    {
                        Console.WriteLine("\n");
                        Console.Write("Enter user's ID: ");
                        int idUser = int.Parse(Console.ReadLine());
                        Console.WriteLine(this.userLogic.GetById(idUser).ToString());
                        Console.Write("Enter user's name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter user's lastname: ");
                        string lastname = Console.ReadLine();
                        Console.Write("Enter user's date of birth: ");
                        DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());

                        try
                        {
                            this.userLogic.Update(new User(idUser, name, lastname, dateOfBirth));
                        }
                        catch (ArgumentNullException nullEx)
                        {
                            Console.WriteLine($"\n{nullEx.Message}");
                            Console.WriteLine("Press any key for continue");
                            Console.ReadKey();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"\n{ex.Message}");
                            Console.WriteLine("Press any key for continue");
                            Console.ReadKey();
                        }

                        this.Start();
                        break;
                    }

                case ConsoleKey.D2:
                    {
                        Console.WriteLine("\n");
                        Console.Write("Enter award's Id: ");
                        int idAward = int.Parse(Console.ReadLine());
                        Console.WriteLine(this.awardLogic.GetById(idAward).ToString());
                        Console.Write("Enter award's title: ");
                        string title = Console.ReadLine();

                        try
                        {
                            this.awardLogic.Update(idAward, title);
                        }
                        catch (ArgumentNullException nullEx)
                        {
                            Console.WriteLine($"\n{nullEx.Message} \n ");
                            Console.WriteLine("Press any key for continue");
                            Console.ReadKey();
                        }

                        this.Start();
                        break;
                    }

                case ConsoleKey.D3:
                    {
                        this.Start();
                        break;
                    }

                default:
                    return;
            }
        }

        /// <summary>
        /// Menu action - delete
        /// </summary>
        private void Delete()
        {
            Console.Clear();
            Console.WriteLine("Delete menu: \n");
            Console.WriteLine("1. Delete user");
            Console.WriteLine("2. Delete award");
            Console.WriteLine("3. Delete user's award");
            Console.WriteLine("4. To main menu");

            Console.Write("\nChoose menu item ");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    {
                        Console.WriteLine("\n");
                        Console.Write("Enter user's Id: ");
                        int idUser = int.Parse(Console.ReadLine());

                        try
                        {
                            this.userLogic.Delete(idUser);
                            this.awardLogic.DeleteByUser(idUser);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"\n{ex.Message}");
                            Console.WriteLine("Press any key for continue");
                            Console.ReadKey();
                        }

                        this.Start();
                        break;
                    }

                case ConsoleKey.D2:
                    {
                        Console.WriteLine("\n");
                        Console.Write("Enter award's Id: ");
                        int idAward = int.Parse(Console.ReadLine());

                        try
                        {
                            this.awardLogic.Delete(idAward);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"\n{ex.Message}");
                            Console.WriteLine("Press any key for continue");
                            Console.ReadKey();
                        }

                        this.Start();
                        break;
                    }

                case ConsoleKey.D3:
                    {
                        Console.WriteLine("\n");
                        Console.Write("Enter user's awards: ");
                        int idUser = int.Parse(Console.ReadLine());

                        try
                        {
                            this.awardLogic.DeleteByUser(idUser);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"\n{ex.Message}");
                            Console.WriteLine("Press any key for continue");
                            Console.ReadKey();
                        }

                        this.Start();
                        break;
                    }

                case ConsoleKey.D4:
                    {
                        this.Start();
                        break;
                    }

                default:
                    return;
            }
        }

        /// <summary>
        /// Menu action - show
        /// </summary>
        private void Show()
        {
            Console.Clear();

            Console.WriteLine("Show menu: \n");

            Console.WriteLine("1. Show all users");
            Console.WriteLine("2. Show user by Id");
            Console.WriteLine("3. Show award by Id");
            Console.WriteLine("4. To main menu");

            Console.Write("\nChoose menu item ");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    {
                        Console.WriteLine("\n");
                        var listUsers = this.userLogic.GetAll();
                        if (listUsers != null)
                        {
                            foreach (var user in listUsers)
                            {
                                Console.WriteLine(user.ToString());
                                var listAwards = this.awardLogic.GetAllByUserId(user.Id);
                                foreach (var award in listAwards)
                                {
                                    Console.WriteLine(award.ToString());
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine($"This table is empty");
                        }

                        Console.WriteLine("\nPress any key for continue");
                        Console.ReadKey();

                        this.Start();
                        break;
                    }

                case ConsoleKey.D2:
                    {
                        Console.WriteLine("\n");
                        Console.Write("Enter user's Id: ");
                        int iduser = int.Parse(Console.ReadLine());
                        var user = this.userLogic.GetById(iduser);
                        var listAwards = this.awardLogic.GetAllByUserId(iduser);
                        if (user != null)
                        {
                            Console.WriteLine(user.ToString());
                        }
                        else
                        {
                            Console.WriteLine($"This user wasn't create or was deleted");
                        }

                        foreach (var award in listAwards)
                        {
                            Console.WriteLine(award.ToString());
                        }

                        Console.WriteLine("\nPress any key for continue");
                        Console.ReadKey();

                        this.Start();
                        break;
                    }

                case ConsoleKey.D3:
                    {
                        Console.WriteLine("\n");
                        Console.Write("Enter award's Id: ");

                        var item = this.awardLogic.GetById(int.Parse(Console.ReadLine()));

                        if (item != null)
                        {
                            Console.WriteLine(item.ToString());
                        }
                        else
                        {
                            Console.WriteLine($"This award wasn't create or was deleted");
                        }

                        Console.WriteLine("\nPress any key for continue");
                        Console.ReadKey();

                        this.Start();
                        break;
                    }

                case ConsoleKey.D4:
                    {
                        this.Start();
                        break;
                    }

                default:
                    return;
            }
        }

        /// <summary>
        /// Menu action - Terminate
        /// </summary>
        private void Terminate()
        {
            this.userLogic.Terminate();
            this.awardLogic.Terminate();
        }
    }
}
