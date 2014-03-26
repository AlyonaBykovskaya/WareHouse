using System;
using System.Collections.Generic;
using System.Linq;


namespace WareHouse
{
    internal class AddingUser
    {
        public void AddNewUser(List<Product> products, List<User> users)
        {
            try
            {
                DateTime date;
                string year, gender, role, password, name, surname, login;

                do
                {
                    Console.WriteLine(ConstString.Name29);
                    login = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(login));

                do
                {
                    Console.WriteLine(ConstString.Name30);
                    password = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(password));

                do
                {
                    Console.WriteLine(ConstString.Name31);
                    name = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(name));

                do
                {
                    Console.WriteLine(ConstString.Name32);
                    surname = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(surname));

                do
                {
                    Console.WriteLine(ConstString.Name33);
                    year = Console.ReadLine();
                } while (!DateTime.TryParse(year, out date));

                do
                {
                    Console.WriteLine(ConstString.Name34);
                    gender = Console.ReadLine();
                } while ((gender != "man") && (gender != "woman"));

                do
                {
                    Console.WriteLine(ConstString.Name35);
                    role = Console.ReadLine();
                } while ((role != "manager") && (role != "user"));

                users.Add(new User()
                {
                    Login = login,
                    Password = password,
                    Name = name,
                    Surname = surname,
                    YearOfBirth = date,
                    Gender = gender,
                    Role = role
                });

                string answer;

               do
                {
                    Console.Clear();
                    Console.WriteLine(ConstString.Name4);
                    answer = Console.ReadLine();
                } while ((answer != "1") && (answer != "2"));

                if (answer == "1")
                {
                   User u =new User();
                   u.WriteUsers(users, ConstString.Name8);
                   Console.WriteLine(ConstString.Name6);
                }

                else
                    {
                        Console.WriteLine(ConstString.Name5);
                        string answer2 = Console.ReadLine();
                        if (answer2 == "1")
                        {
                            var item1 = users.Single(p => p.Login == login);
                            users.Remove(item1);
                            Console.WriteLine(ConstString.Name114);

                        }
                        if (answer2 == "2")
                        {

                            User u = new User();
                            u.WriteUsers(users, ConstString.Name8);

                        Console.WriteLine(ConstString.Name6);

                        }
                    }

                
                string item;
                do
                {   Console.WriteLine();
                    Console.WriteLine(ConstString.Name106);
                    item = Console.ReadLine();
                } while ((item != "0") && (item != "1"));
                if (item == "0")
                {

                    UserInteraction u = new UserInteraction();
                    u.Display(products, users);
                }
                else
                {
                    ViewUsers v = new ViewUsers();
                    v.ShowUsers(products, users);
                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine(ConstString.Name117);
                Console.WriteLine();
                Console.WriteLine(ConstString.Name79);
                AddNewUser(products, users);


            }
        }


        }
    }

