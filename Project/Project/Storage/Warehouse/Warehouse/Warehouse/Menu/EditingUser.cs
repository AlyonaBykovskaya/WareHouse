using System;
using System.Collections.Generic;
using System.Linq;


namespace WareHouse
{
    class EditingUser
    {
        public void EditUser(List<Product> products, List<User> users)

        {

            try
            {
                Console.WriteLine(ConstString.Name15);
                Console.WriteLine();
                string login = Console.ReadLine();


                User result = users.FirstOrDefault(x => x.Login == login);

                if (result == null)
                {
                    Console.Clear();
                    Console.WriteLine(ConstString.Name104);
                    Console.WriteLine();
                    EditUser(products, users);

                }
                Console.WriteLine();
                Console.WriteLine(ConstString.Name107, result.Login);
                string login1 = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(login1))
                {
                    result.Login = login1; 
                }
                Console.WriteLine(ConstString.Name111, result.Password);
                string password = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(password))
                {
                    result.Password = password;
                }
                Console.WriteLine(ConstString.Name108, result.Name);
                string name = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(name))
                {
                    result.Name = name;
                }
                Console.WriteLine(ConstString.Name109, result.Surname);
                string surname = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(surname))
                {
                    result.Surname = surname;
                }
                Console.WriteLine(ConstString.Name112, result.YearOfBirth);
                string date = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(date))
                {
                    result.YearOfBirth = Convert.ToDateTime(date);
                }

                Console.WriteLine(ConstString.Name113, result.Gender);
                string gender = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(gender))
                {
                    result.Gender = gender;
                }
                Console.WriteLine(ConstString.Name110, result.Role);
                string role = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(role))
                {
                    result.Role = role;
                }
                User user = new User();
                user.WriteUsers(users, ConstString.Name8);

                string item;
                do
                {
                    Console.WriteLine(ConstString.Name49);
                    item = Console.ReadLine();
                } while ((item != "1")&&(item != "2"));
                if (item == "1")
                {
                    UserInteraction u = new UserInteraction();
                    u.Display(products, users);
                }
                else
                {
                    ViewUsers v=new ViewUsers();
                    v.ShowUsers(products, users);
                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine(ConstString.Name78);
                Console.WriteLine();
                Console.WriteLine(ConstString.Name79);
                EditUser(products, users);

            }
        }


        }
    }

