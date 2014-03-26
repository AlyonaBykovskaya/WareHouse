using System;
using System.Collections.Generic;
using System.Linq;


namespace WareHouse
{
    class RemoveProduct
    {
        public void Remove(List <Product> products,List <User> users)
        {
           Console.Clear();
           Console.WriteLine(ConstString.Name100);
           Console.WriteLine();
           string number = Console.ReadLine();
           Console.WriteLine();

           Product result = products.FirstOrDefault(x => x.NumberOfProduct == number);

           if (result == null)
           {
               Console.Clear();
               Console.WriteLine(ConstString.Name22);
               Console.WriteLine();
               Console.Clear();
               Remove(products, users);

           }
            string answer;
            do{ Console.WriteLine(ConstString.Name115,number);
            Console.WriteLine();
            answer = Console.ReadLine();
            } while ((answer!="1")&&(answer!="2"));

            
            if (answer == "1")
            {
                products.Remove(result);
                Product p = new Product();
                p.WriteProducts(products, ConstString.Name7);
                Console.WriteLine(ConstString.Name114);

            

            string answer2;
                do
                {
                    Console.WriteLine();
                    Console.WriteLine(ConstString.Name103);
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
                        Remove(products, users);
                    break;

                    case "2":
                        ViewProducts view = new ViewProducts();
                        view.ShowProducts(products, users);
                    break;

                }

            }
            else
            {
                string answer2;
                do
                {   Console.Clear();
                    Console.WriteLine(ConstString.Name103);
                    answer2 = Console.ReadLine();
                    Console.WriteLine();
                } while ((answer2 != "0") && (answer2 != "1") && (answer2 != "2"));

            switch (answer2)
                {

                case "0":
                    UserInteraction user =new UserInteraction();
                    user.Display(products,users);
                break;

                case "1":
                    Remove(products, users);
                break;

                case "2":
                    ViewProducts view =new ViewProducts();
                    view.ShowProducts(products,users);
                break;

                }

            }
            

        }
    }
}
