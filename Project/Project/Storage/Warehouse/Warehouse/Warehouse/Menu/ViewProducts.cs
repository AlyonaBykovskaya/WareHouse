using System;
using System.Collections.Generic;
using System.Linq;


namespace WareHouse
{
    internal class ViewProducts
    {


        internal void ShowProducts(List<Product> products, List<User> users) //Display the CSV file
        {
            #region Const

            const int elemCount = 3;

            #endregion


            int page = 1; //изначально,какая страница 
            double productsCount = products.Count();//считаем,сколько у нас всего товаров на складе(их 60)
            var pages = Math.Ceiling(productsCount / elemCount);//ПОЛУЧАЕМ,СКОЛЬКО СТРАНИЦ(3)
            var showProducts = products.Skip((page - 1) * elemCount).Take(elemCount);
            Console.Clear();
            Console.WriteLine("                                       Products:");
            Console.WriteLine(ConstString.Name63, page);
            Console.WriteLine();
            foreach (var showProduct in showProducts)
            {

                Console.WriteLine(ConstString.Name68,showProduct.NameOfProduct);
                Console.WriteLine(ConstString.Name69, showProduct.NumberOfProduct);
                Console.WriteLine(ConstString.Name70, showProduct.PriceOfProduct);
                Console.WriteLine(ConstString.Name71, showProduct.CategoryOfProduct);
                Console.WriteLine(ConstString.Name72, showProduct.DateAndTime);
                Console.WriteLine();


            }

            Console.WriteLine();
            Console.WriteLine(ConstString.Name73);
            string item;
            do
            {

                item = Console.ReadLine();

                switch (item)
                {

                    case "1":
                        if (page > 1)
                        {

                            Console.Clear();

                            page--;
                            var showProducts1 = products.Skip((page - 1) * elemCount).Take(elemCount);
                            Console.WriteLine("                                       Products:");
                            Console.WriteLine(ConstString.Name63, page);
                            Console.WriteLine();
                            foreach (var showProduct in showProducts1)
                            {

                                Console.WriteLine(ConstString.Name68, showProduct.NameOfProduct);
                                Console.WriteLine(ConstString.Name69, showProduct.NumberOfProduct);
                                Console.WriteLine(ConstString.Name70, showProduct.PriceOfProduct);
                                Console.WriteLine(ConstString.Name71, showProduct.CategoryOfProduct);
                                Console.WriteLine(ConstString.Name72, showProduct.DateAndTime);
                                Console.WriteLine();


                            }

                        }

                        if (page == 1)
                        {
                           Console.WriteLine();
                           Console.WriteLine(ConstString.Name73);
                        }
                        if ((page > 1) && (page != pages))
                        {
                            Console.WriteLine();
                            Console.WriteLine(ConstString.Name37);
                        }
                        if (page == pages)
                        {
                            Console.WriteLine();
                            Console.WriteLine(ConstString.Name76);
                        }

                        break;
                    case "2":
                        if (page < pages)
                        {
                            Console.Clear();
                            page++;
                            var showProducts1 = products.Skip((page - 1) * elemCount).Take(elemCount);
                            Console.WriteLine("                                       Products:");
                            Console.WriteLine(ConstString.Name63, page);
                            Console.WriteLine();
                            foreach (var showProduct in showProducts1)
                            {

                                Console.WriteLine(ConstString.Name68, showProduct.NameOfProduct);
                                Console.WriteLine(ConstString.Name69, showProduct.NumberOfProduct);
                                Console.WriteLine(ConstString.Name70, showProduct.PriceOfProduct);
                                Console.WriteLine(ConstString.Name71, showProduct.CategoryOfProduct);
                                Console.WriteLine(ConstString.Name72, showProduct.DateAndTime);
                                Console.WriteLine();


                            }
                        }
                        if (page == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine(ConstString.Name73);
                        }
                        if ((page > 1) && (page != pages))
                        {
                            Console.WriteLine();
                            Console.WriteLine(ConstString.Name37);
                        }
                        if (page == pages)
                        {
                            Console.WriteLine();
                            Console.WriteLine(ConstString.Name76);
                        }


                        break;
                    case "3":

                        Console.Clear();
                        string number;

                        do
                        {
                            Console.Clear();
                            Console.WriteLine(ConstString.Name75);
                            number = Console.ReadLine();

                        } while (!products.Exists(x => x.NumberOfProduct == number));

                        Console.WriteLine();

                        Product result = products.FirstOrDefault(x => x.NumberOfProduct == number);
                        Console.WriteLine(ConstString.Name68, result.NameOfProduct);
                        Console.WriteLine(ConstString.Name69, result.NumberOfProduct);
                        Console.WriteLine(ConstString.Name70, result.PriceOfProduct);
                        Console.WriteLine(ConstString.Name71, result.CategoryOfProduct);
                        Console.WriteLine(ConstString.Name72, result.DateAndTime);

                        Console.WriteLine();

                        string answer;
                        do
                        {
                            Console.WriteLine(ConstString.Name2);
                            answer = Console.ReadLine();

                        } while ((answer != "0") && (answer != "1"));
                        if (answer == "0")
                        {
                            Console.Clear();
                            var use = new UserInteraction();
                            use.Display(products, users);
                        }
                        else
                        {   Console.Clear();
                        ShowProducts(products, users);
                        }
                        break;
                    case "4":
                        Console.Clear();
                        AddingProduct a=new AddingProduct();
                        a.AddNewProduct(products, users);
                        break;
                    case "5":
                        Console.Clear();
                        EditingProduct e=new EditingProduct();
                        e.EditProduct(products, users);
                        break;
                  
                    case "6":
                        Console.Clear();
                        RemoveProduct r=new RemoveProduct();
                        r.Remove(products, users);
                        break;

                }
            } while (item != "0");

            var u = new UserInteraction();
            u.Display(products, users);

        }


        internal void ShowProductsForUsers(List<Product> products, List<User> users)
        {
            #region Const

            const int elemCount = 3;

            #endregion


            int page = 1; //изначально,какая страница 
            double productsCount = products.Count();//считаем,сколько у нас всего товаров на складе(их 60)
            var pages = Math.Ceiling(productsCount / elemCount);//ПОЛУЧАЕМ,СКОЛЬКО СТРАНИЦ(3)
            var showProducts = products.Skip((page - 1) * elemCount).Take(elemCount);
            Console.WriteLine("                                       Products:");
            Console.WriteLine(ConstString.Name63, page);
            Console.WriteLine();
            foreach (var showProduct in showProducts)
            {

                Console.WriteLine(ConstString.Name68, showProduct.NameOfProduct);
                Console.WriteLine(ConstString.Name69, showProduct.NumberOfProduct);
                Console.WriteLine(ConstString.Name70, showProduct.PriceOfProduct);
                Console.WriteLine(ConstString.Name71, showProduct.CategoryOfProduct);
                Console.WriteLine(ConstString.Name72, showProduct.DateAndTime);
                Console.WriteLine();


            }

            Console.WriteLine();
            Console.WriteLine(ConstString.Name);
            string item;
            do
            {

                item = Console.ReadLine();

                switch (item)
                {

                    case "1":
                        if (page > 1)
                        {

                            Console.Clear();

                            page--;
                            var showProducts1 = products.Skip((page - 1) * elemCount).Take(elemCount);
                            Console.WriteLine("                                       Products:");
                            Console.WriteLine(ConstString.Name63, page);
                            Console.WriteLine();
                            foreach (var showProduct in showProducts1)
                            {

                                Console.WriteLine(ConstString.Name68, showProduct.NameOfProduct);
                                Console.WriteLine(ConstString.Name69, showProduct.NumberOfProduct);
                                Console.WriteLine(ConstString.Name70, showProduct.PriceOfProduct);
                                Console.WriteLine(ConstString.Name71, showProduct.CategoryOfProduct);
                                Console.WriteLine(ConstString.Name72, showProduct.DateAndTime);
                                Console.WriteLine();


                            }
                        }

                        if (page == 1)
                        {
                           Console.WriteLine();
                           Console.WriteLine(ConstString.Name);
                        }
                        if ((page > 1) && (page != pages))
                        {
                            Console.WriteLine();
                            Console.WriteLine(ConstString.Name13);
                        }
                        if (page == pages)
                        {
                            Console.WriteLine();
                            Console.WriteLine(ConstString.Name14);
                        }

                        break;
                    case "2":
                        if (page < pages)
                        {
                            Console.Clear();
                            page++;
                            var showProducts1 = products.Skip((page - 1) * elemCount).Take(elemCount);
                            Console.WriteLine("                                       Products:");
                            Console.WriteLine(ConstString.Name63, page);
                            Console.WriteLine();
                            foreach (var showProduct in showProducts1)
                            {

                                Console.WriteLine(ConstString.Name68, showProduct.NameOfProduct);
                                Console.WriteLine(ConstString.Name69, showProduct.NumberOfProduct);
                                Console.WriteLine(ConstString.Name70, showProduct.PriceOfProduct);
                                Console.WriteLine(ConstString.Name71, showProduct.CategoryOfProduct);
                                Console.WriteLine(ConstString.Name72, showProduct.DateAndTime);
                                Console.WriteLine();


                            }
                        }

                        if (page == 1)
                        {
                           Console.WriteLine();
                           Console.WriteLine(ConstString.Name);
                        }
                        if ((page > 1) && (page != pages))
                        {
                            Console.WriteLine();
                            Console.WriteLine(ConstString.Name13);
                        }
                        if (page == pages)
                        {
                            Console.WriteLine();
                            Console.WriteLine(ConstString.Name14);
                        }


                        break;
                    case "3":

                        Console.Clear();
                        string number;

                        do{
                            Console.WriteLine(ConstString.Name75);
                            number = Console.ReadLine();


                        } while (!products.Exists(c => c.NumberOfProduct == number));

                        Product result = products.FirstOrDefault(x => x.NumberOfProduct == number);

                            Console.WriteLine(ConstString.Name68, result.NameOfProduct);
                            Console.WriteLine(ConstString.Name69, result.NumberOfProduct);
                            Console.WriteLine(ConstString.Name70, result.PriceOfProduct);
                            Console.WriteLine(ConstString.Name71, result.CategoryOfProduct);
                            Console.WriteLine(ConstString.Name72, result.DateAndTime);

                        string answer;
                        do
                        {
                            Console.WriteLine(ConstString.Name2);
                            answer = Console.ReadLine();
                         
                           
                        } while ((answer != "0") && (answer != "1"));
                        if (answer == "0")
                        {
                            Console.Clear();
                            var use = new UserInteraction();
                            use.Authentication(users);
                            use.Display(products, users);
                        }
                        else
                        {
                            Console.Clear();
                            ShowProductsForUsers(products, users);
                        }
                        break;


                }
            } while (item != "0");

            var u = new UserInteraction();
            u.Display(products, users);


        }
    }
}