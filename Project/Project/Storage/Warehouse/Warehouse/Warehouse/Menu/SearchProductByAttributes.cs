using System;
using System.Collections.Generic;
using System.Linq;



namespace WareHouse
{
    internal class SearchProductByAttributes

    {
        internal void FindProducts(List<Product> products,List<User> users) //Display the CSV file
        {

            
            string name,number, price, category, dateTime;

            do
            {

                Console.WriteLine(ConstString.Name77);
                Console.WriteLine(ConstString.Name16);
                name = Console.ReadLine();
                Console.WriteLine(ConstString.Name17);
                number = Console.ReadLine();
                Console.WriteLine(ConstString.Name18);
                price = Console.ReadLine();
                Console.WriteLine(ConstString.Name19);
                category = Console.ReadLine();
                Console.WriteLine(ConstString.Name20);
                dateTime = Console.ReadLine();
               

            } while (!products.Exists(y => y.NameOfProduct.StartsWith(name))

                     || !products.Exists(y => y.NumberOfProduct.StartsWith(number))
                     || !products.Exists(y => y.PriceOfProduct.ToString().StartsWith(price))
                     || !products.Exists(y => y.CategoryOfProduct.StartsWith(category))
                     || !products.Exists(y => y.DateAndTime.ToString().StartsWith(dateTime)));

            Console.Clear();
            var result = products
                .Where(f => f.NameOfProduct.StartsWith(name))
                .Where(f => f.NumberOfProduct.StartsWith(number))
                .Where(f => f.PriceOfProduct.ToString().StartsWith(price.ToString()))
                .Where(f => f.CategoryOfProduct.StartsWith(category))
                .Where(f => f.DateAndTime.ToString().StartsWith(dateTime.ToString()))
                .Select(
                   
                p => new {p.NameOfProduct, p.NumberOfProduct, p.PriceOfProduct, p.CategoryOfProduct, p.DateAndTime});
           
            
            foreach (var f in result)
            {

                Console.WriteLine(ConstString.Name68, f.NameOfProduct);
                Console.WriteLine(ConstString.Name69, f.NumberOfProduct);
                Console.WriteLine(ConstString.Name70, f.PriceOfProduct);
                Console.WriteLine(ConstString.Name71, f.CategoryOfProduct);
                Console.WriteLine(ConstString.Name72, f.DateAndTime);
                Console.WriteLine();
 

            }

            string item;
            do
            {
                Console.WriteLine();
                Console.WriteLine(ConstString.Name91);
                item = Console.ReadLine();
            } while (item != "1");

            UserInteraction u=new UserInteraction();
            u.Display(products,users);


        }
    }
}