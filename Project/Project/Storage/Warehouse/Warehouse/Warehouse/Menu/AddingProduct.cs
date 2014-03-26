using System;
using System.Collections.Generic;
using System.Linq;



namespace WareHouse
{
    internal class AddingProduct
    {
        public void AddNewProduct(List<Product> products, List<User> users) //add new product to collection
        {
            string name, number, category, dateTime, price1;
            DateTime date;
            decimal price;

            try
            {


                Console.WriteLine(ConstString.Name99);
                Console.WriteLine();

                do
                {
                    Console.WriteLine(ConstString.Name16);
                    name = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(name));
                if (name == "#")
                {
                    UserInteraction user=new UserInteraction();
                    user.Display(products, users);
                }

                do
                {
                    Console.WriteLine(ConstString.Name17);
                    number = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(number));
                if (number == "#")
                {
                    UserInteraction user = new UserInteraction();
                    user.Display(products, users);
                }

                do
                {
                    Console.WriteLine(ConstString.Name18);
                    price1 = Console.ReadLine();
                } while (!decimal.TryParse(price1, out price) && (price1 != "#"));
                if (price1 == "#")
                {
                    UserInteraction user = new UserInteraction();
                    user.Display(products, users);
                }

                do
                {
                    Console.WriteLine(ConstString.Name19);
                    category = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(category));
                if (category == "#")
                {
                    UserInteraction user = new UserInteraction();
                    user.Display(products, users);
                }

                do
                {
                    Console.WriteLine(ConstString.Name20);
                    dateTime = Console.ReadLine();
                } while (!DateTime.TryParse(dateTime, out date) && (dateTime != "#"));

                if (dateTime == "#")
                {
                    UserInteraction user = new UserInteraction();
                    user.Display(products, users);
                }

                products.Add(new Product()
                {
                    NameOfProduct = name,
                    NumberOfProduct = number,
                    PriceOfProduct = price,
                    CategoryOfProduct = category,
                    DateAndTime = date
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

                    Product p = new Product();
                    p.WriteProducts(products, ConstString.Name7);
                    Console.WriteLine(ConstString.Name6);
                    

                }
                else
                {
                    Console.WriteLine(ConstString.Name5);
                    string answer2 = Console.ReadLine();
                    if (answer2 == "1")
                    {
                        var item1 = products.Single(p => p.NameOfProduct == name);
                        products.Remove(item1);
                        Console.WriteLine(ConstString.Name114);
                    }
                    if (answer2 == "2")
                    {

                        Product p = new Product();
                        p.WriteProducts(products, ConstString.Name7);
                        Console.WriteLine(ConstString.Name6);

                      

                    }
                }


                string item;
                do
                {
                    Console.WriteLine();
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
                    ViewProducts view = new ViewProducts();
                    view.ShowProducts(products,users);
                }


            }
        

           catch
            {
                Console.Clear();
                Console.WriteLine(ConstString.Name117);
                Console.WriteLine();
                Console.WriteLine(ConstString.Name79);
                AddNewProduct(products, users);


            }
            //} while ((name != "#") || (number != "#") || (category != "#") || (dateTime != "#") || (price1 != "#"));
       
    }
    }
}