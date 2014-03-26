using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WareHouse
{
    internal class SpecialFunctions
    {

        public void MenuFunction()
        {
            Console.Clear();
            Console.WriteLine(ConstString.Name92);
            Console.WriteLine(ConstString.Name93);
            Console.WriteLine(ConstString.Name96);
        }

        public void Function(List<Product> products, List<User> users)
        {
            string item;
            do
            {
                item = Console.ReadLine();
                if ((item != "0") && (item != "1") && (item != "2"))
                {
                    Console.WriteLine(ConstString.Name59);
                }

            } while ((item != "0") && (item != "1") && (item != "2"));

            switch (item)
            {
                case "0":
                    UserInteraction user = new UserInteraction();
                    user.Display(products, users);
                    break;
                case "1":
                    Console.Clear();
                    CalculateVatAsync();
                   
                    Console.Read();
                    Console.Read();
                    MenuFunction();
                    Function(products, users);

                   
                    break;
                case "2": 
                    Console.Clear();
                    string price;
                    decimal price1;

                    do
                    {
                        Console.WriteLine(ConstString.Name61);
                        price = Console.ReadLine();
                    } while (!decimal.TryParse(price, out price1));

                    CalculateQuantity(products,price1);
                    Console.Read();
                    Console.Read();
                    MenuFunction();
                    Function(products, users);
                    
                    break;
            }

        }
       

        static async void CalculateVatAsync()
        {
            Console.Clear();
            await Task.Run(() => Calculation.CalculateVat());
            Console.WriteLine();
            Console.WriteLine(ConstString.Name123);
            
          
        }



        static async void CalculateQuantity(List<Product> products,decimal price1)
        {
            await Task.Run(() => Calculation.CalculatePrice(products,price1));
            Console.WriteLine();
            Console.WriteLine(ConstString.Name123);
          

        }

        
    }

    class Calculation
    {

        public static void CalculatePrice(List<Product> products,decimal price1)
        {
            Console.WriteLine();
            
            var grouped = products.GroupBy(p => p.CategoryOfProduct)
            .Select(m => new
            {
            CategoryOfProduct = m.Key,
            PriceOfProduct = m.Count(p => p.PriceOfProduct < price1) 
            });
           
            foreach (var g in grouped)
            {
                if (g.PriceOfProduct != 0)
                {
                    Console.WriteLine("\n{0}  {1}", g.CategoryOfProduct, g.PriceOfProduct);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(ConstString.Name124, g.CategoryOfProduct);

                }
            }

          
        }

        public static void CalculateVat()
        {
            Product p1 = new Product();
            decimal vat = p1.ReadProducts(ConstString.Name7).Sum(x => x.PriceOfProduct) / 5;
            Console.WriteLine(ConstString.Name60, vat);
           
        }
      
   
    }
}

