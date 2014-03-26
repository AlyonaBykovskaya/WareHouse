using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Xml;

namespace WareHouse
{
    internal class SaveLoadBackup : Screen
    {
        public List<string> Read()
        {
            Console.Clear();
            List<string> menuList = new List<string>(); // Создаем массив айдишников  
            string id; // отдельно взятый айдишник  

            XmlDocument xd = new XmlDocument();
            FileStream fs = new FileStream(ConstString.Name98, FileMode.Open);
            xd.Load(fs);
            XmlNodeList list = xd.GetElementsByTagName("item");

            // Если в базе есть записи  
            if (list.Count > 0)
            {
                foreach (XmlElement item in list)
                {
                    id = (item.GetAttribute("Text")); // Считывае ID  
                    menuList.Add(id); // Добавляем его в массив  
                }

                foreach (var ml in menuList)
                {
                    Console.WriteLine(ml);
                }

                fs.Close(); // Закрываем поток  

            }
            return menuList;
        }

        public void Choise(List<Product> products, List<User> users)
        {

            string answer;

            do
            {
                Console.WriteLine(ConstString.Name58);
                answer = Console.ReadLine();
            } while ((answer != "1") && (answer != "2") && (answer != "3") && (answer != "4") && (answer != "0"));


            switch (answer)
            {

                case "1":
                    Console.Clear();
                    string path2;

                    try
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine(ConstString.Name38);
                            path2 = Console.ReadLine();
                            if (!Directory.Exists(path2))
                            {
                                Console.WriteLine();
                                Console.WriteLine(ConstString.Name39);
                                Console.WriteLine();
                            }

                        } while (path2 != null && !Directory.Exists(path2));

                        string nameofCopyProduct;
                        do
                        {
                            Console.WriteLine(ConstString.Name118);
                            nameofCopyProduct = Console.ReadLine();
                        } while (nameofCopyProduct == null);

                        string pathString = Path.Combine(path2, nameofCopyProduct + ".csv");

                        Directory.CreateDirectory(path2);
                        File.Copy(ConstString.Name7, pathString, true);
                        Console.WriteLine(ConstString.Name40);

                    }

                    catch
                    {
                        Console.Clear();
                        Console.WriteLine(ConstString.Name41);
                        Thread.Sleep(4000);
                        Read();
                        Choise(products, users);
                    }

                    Console.WriteLine();
                    Console.WriteLine(ConstString.Name10);
                    string answer2 = Console.ReadLine();
                    switch (answer2)
                    {
                        case "0":
                            Console.Clear();
                            UserInteraction u = new UserInteraction();
                            u.Display(products, users);
                            break;
                        case "1":
                            Console.Clear();
                            Read();
                            Choise(products, users);
                            break;


                    }
                    break;
                case "2":
                    Console.Clear();
                    string path3;

                    try
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine(ConstString.Name43);
                            path3 = Console.ReadLine();
                            if (!Directory.Exists(path3))
                            {
                                Console.WriteLine();
                                Console.WriteLine(ConstString.Name39);
                                Console.WriteLine();
                            }

                        } while (path3 != null && !Directory.Exists(path3));
                        string nameofCopyUser;
                        do
                        {
                            Console.WriteLine(ConstString.Name118);
                            nameofCopyUser = Console.ReadLine();
                        } while (nameofCopyUser == null);

                        string pathString = Path.Combine(path3, nameofCopyUser + ".csv");

                        Directory.CreateDirectory(path3);
                        File.Copy(ConstString.Name8, pathString, true);
                        Console.WriteLine(ConstString.Name40);

                    }

                    catch
                    {
                        Console.Clear();
                        Console.WriteLine(ConstString.Name41);
                        Thread.Sleep(4000);
                        Read();
                        Choise(products, users);
                    }

                    Console.WriteLine();
                    string answer3;
                    do
                    {

                        Console.WriteLine(ConstString.Name10);
                        answer3 = Console.ReadLine();
                    } while (answer3 != "0" && answer3 != "1");

                    switch (answer3)
                    {
                        case "0":
                            Console.Clear();
                            UserInteraction u = new UserInteraction();
                            u.Display(products, users);
                            break;
                        case "1":
                            Console.Clear();
                            Read();
                            Choise(products, users);
                            break;

                    }

                    break;
                case "3":

                    Console.Clear();
                    string Path2;
                    try
                    {

                        do
                        {
                            Console.WriteLine(ConstString.Name95);
                            Path2 = Console.ReadLine();

                            if (!Directory.Exists(Path2) && Path2 != null)
                            {
                                Console.WriteLine();
                                Console.WriteLine(ConstString.Name39);
                                Console.WriteLine();
                            }

                        } while (Path2 != null && !Directory.Exists(Path2));
                        string nameofCopyProduct;
                        do
                        {
                            Console.WriteLine(ConstString.Name118);
                            nameofCopyProduct = Console.ReadLine();
                        } while (nameofCopyProduct == null);


                        Product p = new Product();
                        string pathString = Path.Combine(Path2, nameofCopyProduct + ".csv");
                        var goods = p.ReadProducts(pathString);
                        p.WriteProducts(goods, ConstString.Name7);

                        Console.WriteLine(ConstString.Name94);
                        Console.WriteLine();

                        string answer4;
                        do
                        {
                            Console.WriteLine(ConstString.Name11);
                            answer4 = Console.ReadLine();
                        } while (answer4 != "0" && answer4 != "1");


                        switch (answer4)
                        {
                            case "0":
                                Console.Clear();
                                UserInteraction u = new UserInteraction();
                                u.Display(products, users);
                                break;
                            case "1":
                                Read();
                                Choise(products, users);
                                break;


                        }
                    }

                    catch
                    {
                        Console.Clear();
                        Console.WriteLine(ConstString.Name121);
                        Thread.Sleep(4000);
                        Read();
                        Choise(products, users);

                    }

                    break;
                case "4":

                    Console.Clear();
                    string Path3;
                    try
                    {
                        do
                        {
                            Console.WriteLine(ConstString.Name95);
                            Path3 = Console.ReadLine();

                            if (!Directory.Exists(Path3) && Path3 != null)
                            {
                                Console.WriteLine();
                                Console.WriteLine(ConstString.Name39);
                                Console.WriteLine();
                            }

                        } while (Path3 != null && !Directory.Exists(Path3));
                        string nameofCopyUser;
                        do
                        {
                            Console.WriteLine(ConstString.Name118);
                            nameofCopyUser = Console.ReadLine();
                        } while (nameofCopyUser == null);
                        Console.WriteLine();
                        string pathString = Path.Combine(Path3, nameofCopyUser + ".csv");
                        User us = new User();
                        var user = us.ReadUsers(pathString);
                        us.WriteUsers(user, ConstString.Name8);
                        Console.WriteLine(ConstString.Name97);
                        Console.WriteLine();

                        string answer5;
                        do
                        {
                            Console.WriteLine(ConstString.Name11);
                            answer5 = Console.ReadLine();
                        } while (answer5 != "0" && answer5 != "1");


                        switch (answer5)
                        {
                            case "0":
                                Console.Clear();
                                UserInteraction u = new UserInteraction();
                                u.Display(products, users);
                                break;
                            case "1":
                                Read();
                                Choise(products, users);
                                break;


                        }
                       

                    }

                    catch
                    {
                        Console.Clear();
                        Console.WriteLine(ConstString.Name121);
                        Thread.Sleep(4000);
                        Read();
                        Choise(products, users);
                    }

                    break;
                case "0":

                    Console.Clear();
                     UserInteraction menu = new UserInteraction();
                     menu.Display(products, users);

                    break;
            }

        }
        }
    }
