using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace WareHouse
{
    internal class Screen
    {

        public List<string> ReadMenu()// read from the xml file main menu
        {

            List<string> menuList = new List<string>(); // Создаем массив айдишников  
            string id; // отдельно взятый айдишник  

            XmlDocument xd = new XmlDocument();
            FileStream fs = new FileStream(ConstString.Name47, FileMode.Open);
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

        public List<string> ReadFullMenu() // read from the xml file additional menu
        {
            List<string> menuList = new List<string>(); // Создаем массив айдишников  
            string id; // отдельно взятый айдишник  

            XmlDocument xd = new XmlDocument();
            FileStream fs = new FileStream(ConstString.Name48, FileMode.Open);
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
    }


}

