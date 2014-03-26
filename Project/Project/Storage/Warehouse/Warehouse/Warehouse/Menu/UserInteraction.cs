using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;



namespace WareHouse
{
    internal class UserInteraction : User
    {
        public string Authentication(List<User> users)
        {
            Console.Clear();
            string login;
            string password;
            do
            {
                Console.Clear();
                Console.WriteLine(ConstString.Name50);
                Console.WriteLine(ConstString.Name51);
                login = Console.ReadLine();
                Console.WriteLine(ConstString.Name52);
                password = Console.ReadLine();
            } while (!users.Any(x => x.Login == login && x.Password == password));

            var name = users.FirstOrDefault(x => x.Login == login && x.Password == password);
            if (name != null)
            {
                Name = name.Name;

            }
            Console.WriteLine(ConstString.Name53, Name);
            Console.WriteLine();
            var role = users.SingleOrDefault(x => x.Login == login && x.Password == password);
            if (role != null)
            {
                Role = role.Role;

            }
            
            Settings.User = new User { Role = Role };
            return Role;

        }

        public void Display(List<Product> foods, List<User> members)
        {
            Console.Clear();
            if (Settings.User == null)
            {
                Authentication(members);
            }

            if ( Settings.User.Role == ConstString.Name55)
            {
                var screen = new Screen();
                screen.ReadFullMenu();

                Console.WriteLine(ConstString.Name58);
                string item = Console.ReadLine();

                switch (item)
                {
                    case "0":
                        ExitProgram escape = new ExitProgram();
                        escape.Exit();
                        break;
                    case "1":

                        Console.Clear();

                        if (Role == ConstString.Name57)
                        {
                            ViewProducts view = new ViewProducts();
                            view.ShowProductsForUsers(foods, members);
                        }
                        else
                        {
                            ViewProducts view = new ViewProducts();
                            view.ShowProducts(foods, members);

                        }
                        break;
                    case "2":
                        Console.Clear();
                        SearchProductByAttributes search = new SearchProductByAttributes();
                        search.FindProducts(foods, members);
                        break;
                    case "3":

                        Console.Clear();
                       SpecialFunctions function=new SpecialFunctions();
                        function.MenuFunction();
                        function.Function(foods, members);
                        break;
                    case "4":
                        Console.Clear();
                        ViewUsers users = new ViewUsers();
                        users.ShowUsers(foods, members);
                        break;
                    case "5":
                        Console.Clear();
                        FindUserByAttribute attribute = new FindUserByAttribute();
                        attribute.FindUsers(members, foods);
                        break;
                    case "6":
                        Console.Clear();
                        SaveLoadBackup saveLoad = new SaveLoadBackup();
                        saveLoad.Read();
                        saveLoad.Choise(foods, members);
                        break;

                }
                if ((item != "0") && (item != "1") && (item != "2") && (item != "3") && (item != "4") && (item != "5") &&
                    (item != "6"))
                {
                    Console.WriteLine(ConstString.Name59);
                    Thread.Sleep(800);
                    Console.Clear();
                    Display(foods, members);
                }
            }

            if (Settings.User.Role == ConstString.Name56)

            {
                var screen1 = new Screen();
                screen1.ReadMenu();

                Console.WriteLine(ConstString.Name58);
                string item = Console.ReadLine();

                switch (item)
                {
                    case "0":
                        ExitProgram escape = new ExitProgram();
                        escape.Exit();
                        break;
                    case "1":

                        Console.Clear();

                        if (Role == ConstString.Name57)
                        {
                            ViewProducts view = new ViewProducts();
                            view.ShowProductsForUsers(foods, members);
                        }
                        else
                        {
                            ViewProducts view = new ViewProducts();
                            view.ShowProducts(foods, members);

                        }
                        break;
                    case "2":
                        Console.Clear();
                        SearchProductByAttributes search = new SearchProductByAttributes();
                        search.FindProducts(foods, members);
                        break;
                    case "3":

                        Console.Clear();
            

                        break;
                }

                if ((item != "0") && (item != "1") && (item != "2") && (item != "3"))
                {
                    Console.WriteLine(ConstString.Name59);
                    Thread.Sleep(800);
                    Console.Clear();
                    Display(foods, members);
                }
            }
            if (Settings.User.Role == ConstString.Name57)
                {
                    var screen = new Screen();
                    screen.ReadMenu();


                    Console.WriteLine(ConstString.Name58);
                    string item = Console.ReadLine();

                    switch (item)
                    {
                        case "0":
                            ExitProgram escape = new ExitProgram();
                            escape.Exit();
                            break;
                        case "1":

                            Console.Clear();

                            if (Role == ConstString.Name57)
                            {
                                ViewProducts view = new ViewProducts();
                                view.ShowProductsForUsers(foods, members);
                            }
                            else
                            {
                                ViewProducts view = new ViewProducts();
                                view.ShowProducts(foods, members);

                            }
                            break;
                        case "2":
                            Console.Clear();
                            SearchProductByAttributes search = new SearchProductByAttributes();
                            search.FindProducts(foods, members);
                            break;
                        case "3":

                            Console.Clear();
                         

                            break;
                    }
                    if ((item != "0") && (item != "1") && (item != "2") && (item != "3"))
                    {
                        Console.WriteLine(ConstString.Name59);
                        Thread.Sleep(800);
                        Console.Clear();
                        Display(foods, members);
                    }
                }


            }

      

    }
}