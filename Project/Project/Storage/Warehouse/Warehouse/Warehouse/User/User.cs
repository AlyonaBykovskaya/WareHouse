using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace WareHouse
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime YearOfBirth { get; set; }
        public string Gender { get; set; }
        public string Role { get; set; }

        public List<User> ReadUsers(string dataPath) //deducted from the data file
        {
            var reader = new StreamReader(File.OpenRead(dataPath));
            reader.ReadLine();
            var users = new List<User>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                if (line != null)
                {
                    var values = line.Split(';');
                    var user = new User
                    {
                        Login = values[0],
                        Password = values[1],
                        Name = values[2],
                        Surname = values[3],
                        YearOfBirth = Convert.ToDateTime(values[4]),
                        Gender = values[5],
                        Role = values[6],

                    };
                    users.Add(user);
                }
                
               
            }
            reader.Close();
            return users;

        }
        public void WriteUsers(List<User> users,string path) //overwrite file changes
        {

            File.WriteAllText(path, "Login" + ";" + "Password" + ";" + "Name" + ";" + "Surname" + ";" + "YearOfBirth" + ";" + "Gender" + ";" + "Role" + "\r\n");
            File.AppendAllLines(path, users.Select(p => p.Login + ";" +
                                                                         p.Password + ";" +
                                                                         p.Name + ";" +
                                                                         p.Surname + ";" +
                                                                         p.YearOfBirth + ";" +
                                                                         p.Gender + ";" +
                                                                         p.Role));


              

        }

    }

}


