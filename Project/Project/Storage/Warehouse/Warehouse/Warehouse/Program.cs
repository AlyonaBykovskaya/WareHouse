using System.Collections.Generic;


namespace WareHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            User user = new User();
            List<User> allUsers = user.ReadUsers(ConstString.Name8);

            Product product = new Product();
            List<Product> goods = product.ReadProducts(ConstString.Name7);

            UserInteraction interaction = new UserInteraction();
            interaction.Authentication(allUsers);
            interaction.Display(goods, allUsers);

          


        }
    }
}
