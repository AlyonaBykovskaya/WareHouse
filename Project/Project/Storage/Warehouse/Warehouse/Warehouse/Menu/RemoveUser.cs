using System;
using System.Collections.Generic;
using System.Linq;


namespace WareHouse
{
    class RemoveUser
    {
        public void Remove(List<User> users, List<Product> products)
        {
            string answer;
            Console.Clear();
            Console.WriteLine(ConstString.Name101);
            Console.WriteLine();
            string login = Console.ReadLine();
            Console.WriteLine();

            User result = users.FirstOrDefault(x => x.Login == login);

            if (result == null)
            {
                Console.Clear();
                Console.WriteLine(ConstString.Name104);
                Console.WriteLine();
                Console.Clear();
                Remove(users, products);

            }

            do
            {
                Console.WriteLine(ConstString.Name116,login);
                Console.WriteLine();
                answer = Console.ReadLine();
            } while ((answer != "1") && (answer != "2"));

           
            if (answer == "1")
            {
                users.Remove(result);
                User u = new User();
                u.WriteUsers(users, ConstString.Name8);
                Console.WriteLine(ConstString.Name114);
                


            string answer2;
                do
                {
                    Console.WriteLine();
                    Console.WriteLine(ConstString.Name105);
                    answer2 = Console.ReadLine();
                    Console.WriteLine();
                } while ((answer2 != "0") && (answer2 != "1") && (answer2 != "2"));

                switch (answer2)
                {

                    case "0":
                        UserInteraction user = new UserInteraction();
                        user.Display(products, users);
                        break;

                    case "1":
                        Remove(users, products);
                        break;

                    case "2":
                        ViewUsers view = new ViewUsers();
                        view.ShowUsers(products, users);
                        break;

                }

            }
            else
            {
                string answer2;
                do
                {
                    Console.Clear();
                    Console.WriteLine(ConstString.Name105);
                    answer2 = Console.ReadLine();
                    Console.WriteLine();
                } while ((answer2 != "0") && (answer2 != "1") && (answer2 != "2"));

                switch (answer2)
                {

                    case "0":
                        UserInteraction user = new UserInteraction();
                        user.Display(products, users);
                        break;

                    case "1":
                        Remove(users, products);
                        break;

                    case "2":
                        ViewUsers view = new ViewUsers();
                        view.ShowUsers(products, users);
                        break;

                }

            }
        }
    }
}
