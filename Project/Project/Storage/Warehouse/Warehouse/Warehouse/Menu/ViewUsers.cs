using System;
using System.Collections.Generic;
using System.Linq;


namespace WareHouse
{
    class ViewUsers
    {
        internal void ShowUsers(List<Product> products, List<User> users) //Display the CSV file
        {
            #region Const
            const int elemCount = 2;
            #endregion


            int page = 1; //изначально,какая страница 
            double userCount = users.Count();//считаем,сколько у нас всего товаров на складе(их 60)
            var pages = Math.Ceiling(userCount / elemCount);//ПОЛУЧАЕМ,СКОЛЬКО СТРАНИЦ(3)
            var showUsers = users.Skip((page - 1) * elemCount).Take(elemCount);
            Console.Clear();
            Console.WriteLine("                                       Users:");
            Console.WriteLine(ConstString.Name63, page);
            Console.WriteLine();

            foreach (var showUser in showUsers)
            {
                Console.WriteLine(ConstString.Name64,showUser.Login);
                Console.WriteLine(ConstString.Name80, showUser.Password);
                Console.WriteLine(ConstString.Name65, showUser.Name);
                Console.WriteLine(ConstString.Name66, showUser.Surname);
                Console.WriteLine(ConstString.Name81, showUser.YearOfBirth);
                Console.WriteLine(ConstString.Name67, showUser.Role);
                Console.WriteLine(ConstString.Name82, showUser.Gender);
                Console.WriteLine();

            }
           
            Console.WriteLine();
            Console.WriteLine(ConstString.Name73);
            string item;
            do
            {

                item = Console.ReadLine();

                switch (item)
                {

                    case "1":
                        if (page > 1)
                        {

                            Console.Clear();

                            page--;
                            var showUsers1 = users.Skip((page - 1) * elemCount).Take(elemCount);
                            Console.WriteLine("                                       Users:");
                            Console.WriteLine(ConstString.Name63, page);
                            Console.WriteLine();
                            foreach (var showUser in showUsers1)
                            {
                                Console.WriteLine(ConstString.Name64, showUser.Login);
                                Console.WriteLine(ConstString.Name80, showUser.Password);
                                Console.WriteLine(ConstString.Name65, showUser.Name);
                                Console.WriteLine(ConstString.Name66, showUser.Surname);
                                Console.WriteLine(ConstString.Name81, showUser.YearOfBirth);
                                Console.WriteLine(ConstString.Name67, showUser.Role);
                                Console.WriteLine(ConstString.Name82, showUser.Gender);
                                Console.WriteLine();

                            }

                        }

                        if (page == 1)
                        {
                            Console.WriteLine(ConstString.Name73);
                        }
                        if ((page > 1) && (page != pages))
                        {
                            Console.WriteLine(ConstString.Name37);
                           
                        }

                        if (page == pages)
                        {
                           
                            Console.WriteLine(ConstString.Name76);
                        }
                        break;
                    case "2":
                        if (page < 3)
                        {
                            Console.Clear();
                            page++;
                            var showUsers1 = users.Skip((page - 1) * elemCount).Take(elemCount);
                            Console.WriteLine("                                       Users:");
                            Console.WriteLine(ConstString.Name63, page);
                            Console.WriteLine();
                            foreach (var showUser in showUsers1)
                            {
                                Console.WriteLine(ConstString.Name64, showUser.Login);
                                Console.WriteLine(ConstString.Name80, showUser.Password);
                                Console.WriteLine(ConstString.Name65, showUser.Name);
                                Console.WriteLine(ConstString.Name66, showUser.Surname);
                                Console.WriteLine(ConstString.Name81, showUser.YearOfBirth);
                                Console.WriteLine(ConstString.Name67, showUser.Role);
                                Console.WriteLine(ConstString.Name82, showUser.Gender);
                                Console.WriteLine();

                            }
                        }
                        if (page == 1)
                        {
                            Console.WriteLine(ConstString.Name73);
                        }
                        if ((page > 1) && (page != pages))
                        {
                            Console.WriteLine(ConstString.Name37);
                           
                        }

                        if (page == pages)
                        {
                           
                            Console.WriteLine(ConstString.Name76);
                        }


                        break;
                    case "3":
                          Console.Clear();
                          string login;

                        do
                        {
                            Console.Clear();
                            Console.WriteLine(ConstString.Name83);
                            login = Console.ReadLine();



                        } while (!users.Exists(x => x.Login == login));

                        Console.WriteLine();

                        User result = users.FirstOrDefault(x => x.Login == login);
                        Console.WriteLine(ConstString.Name64,result.Login);
                        Console.WriteLine(ConstString.Name80, result.Password);
                        Console.WriteLine(ConstString.Name65, result.Name);
                        Console.WriteLine(ConstString.Name66, result.Surname);
                        Console.WriteLine(ConstString.Name81, result.YearOfBirth);
                        Console.WriteLine(ConstString.Name67, result.Role);
                        Console.WriteLine(ConstString.Name82, result.Gender);

                        Console.WriteLine();

                        string answer;
                        do
                        {
                            Console.WriteLine();
                            Console.WriteLine(ConstString.Name2);
                            answer = Console.ReadLine();

                        } while ((answer != "0") && (answer != "1"));
                        if (answer == "0")
                        {
                            Console.Clear();
                            var use = new UserInteraction();
                            use.Display(products, users);
                        }
                        else
                        {
                            Console.Clear();
                            ShowUsers(products, users);
                        }
                        break;

                    case "4":
                        Console.Clear();
                        AddingUser a = new AddingUser();
                        a.AddNewUser(products, users);
                        break;
                    case "5":
                        Console.Clear();
                        EditingUser e = new EditingUser();
                        e.EditUser(products, users);
                        break;
                    case "6":
                        Console.Clear();
                        RemoveUser user = new RemoveUser();
                        user.Remove(users, products);
                        break;
                }
            } while (item != "0");
            var u = new UserInteraction();
            u.Display(products, users);
        }
    }
}