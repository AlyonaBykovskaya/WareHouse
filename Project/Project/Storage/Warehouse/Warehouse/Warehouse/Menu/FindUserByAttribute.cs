using System;
using System.Collections.Generic;
using System.Linq;


namespace WareHouse
{
    internal class FindUserByAttribute
    {
        internal void FindUsers(List<User> users,List<Product> products ) //Display the CSV file
        {
            string login, password, name, surname, yearOfbirth, gender,role;
            do
            {
                Console.WriteLine(ConstString.Name102);
                Console.WriteLine();
                Console.WriteLine(ConstString.Name29);
                login = Console.ReadLine();
                Console.WriteLine(ConstString.Name30);
                password = Console.ReadLine();
                Console.WriteLine(ConstString.Name31);
                name = Console.ReadLine();
                Console.WriteLine(ConstString.Name32);
                surname = Console.ReadLine();
                Console.WriteLine(ConstString.Name33);
                yearOfbirth = Console.ReadLine();
                Console.WriteLine(ConstString.Name34);
                gender = Console.ReadLine();
                Console.WriteLine(ConstString.Name35);
                role = Console.ReadLine();
            } while (!users.Exists(y => y.Login.StartsWith(login))

                     || !users.Exists(y => y.Password.StartsWith(password))
                     || !users.Exists(y => y.Name.ToString().StartsWith(name))
                     || !users.Exists(y => y.YearOfBirth.ToString().StartsWith(yearOfbirth))
                     || !users.Exists(y => y.Gender.ToString().StartsWith(gender))
                     || !users.Exists(y => y.Role.StartsWith(role))
                ); 

            
            var result = users
                .Where(f => f.Login.StartsWith(login))
                .Where(f => f.Password.StartsWith(password))
                .Where(f => f.Name.ToString().StartsWith(name.ToString()))
                .Where(f => f.Surname.StartsWith(surname))
                .Where(f => f.YearOfBirth.ToString().StartsWith(yearOfbirth.ToString()))
                .Where(f => f.Gender.StartsWith(gender))
                .Where(f => f.Role.ToString().StartsWith(role.ToString()))
                .Select(

                    p => new {p.Login, p.Password, p.Name, p.Surname, p.YearOfBirth,p.Gender,p.Role});

            Console.Clear();

            foreach (var f in result)
            {
                Console.WriteLine(ConstString.Name64, f.Login);
                Console.WriteLine(ConstString.Name80, f.Password);
                Console.WriteLine(ConstString.Name65, f.Name);
                Console.WriteLine(ConstString.Name66, f.Surname);
                Console.WriteLine(ConstString.Name81, f.YearOfBirth);
                Console.WriteLine(ConstString.Name82, f.Gender);
                Console.WriteLine(ConstString.Name67, f.Role);
                Console.WriteLine();

            }
            Console.WriteLine();
            string item;
            do
            {
                Console.WriteLine(ConstString.Name91);
                item = Console.ReadLine();
            } while (item != "1");

            UserInteraction u = new UserInteraction();
            u.Display(products, users);


        }
    }
}