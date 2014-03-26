using System;
using System.Collections.Generic;
using System.Linq;


namespace WareHouse
{
    class EditingProduct 
    {
        public void EditProduct(List<Product> products,List<User> users)
        {

            try
            {
                Console.WriteLine(ConstString.Name21);
                Console.WriteLine();
                string number = Console.ReadLine();
                Console.WriteLine();

                Product result = products.FirstOrDefault(x => x.NumberOfProduct == number);

                if (result == null)
                {
                    Console.Clear();
                    Console.WriteLine(ConstString.Name22);
                    Console.WriteLine();
                    EditProduct(products,users);

                }
                Console.WriteLine();
                Console.WriteLine(ConstString.Name23, result.NameOfProduct);
                string name = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(name))
                {
                    result.NameOfProduct = name;
                }

                Console.WriteLine(ConstString.Name24, result.NumberOfProduct);
                string number1 = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(number1))
                {
                    result.NumberOfProduct = number1;
                }
                
                Console.WriteLine(ConstString.Name25, result.PriceOfProduct);
                string price = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(price))
                {
                    result.PriceOfProduct = Convert.ToInt32(price);
                }

                Console.WriteLine(ConstString.Name26, result.CategoryOfProduct);
                string category = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(category))
                {
                    result.CategoryOfProduct = category;
                }

                Console.WriteLine(ConstString.Name27, result.DateAndTime);
                string dateTime = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(dateTime))
                {
                    result.DateAndTime = Convert.ToDateTime(dateTime);
                }

                Product p = new Product();
                p.WriteProducts(products, ConstString.Name7);


                string item;
                do
                {
                    Console.WriteLine(ConstString.Name49);
                    item = Console.ReadLine();
                } while ((item != "1") && (item != "2"));
                if (item == "1")
                {
                    UserInteraction u = new UserInteraction();
                    u.Display(products, users);
                }
                else
                {
                    ViewProducts v = new ViewProducts();
                    v.ShowProducts(products, users);
                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine(ConstString.Name78);
                Console.WriteLine();
                Console.WriteLine(ConstString.Name79);
                EditProduct(products,users);

            }
        }
    }
}
