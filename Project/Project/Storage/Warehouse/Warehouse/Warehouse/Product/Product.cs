using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;



namespace WareHouse
{
    public class Product
    {
        public string NameOfProduct { get; set; }
        public string NumberOfProduct { get; set; }
        public decimal PriceOfProduct { get; set; }
        public string CategoryOfProduct { get; set; }
        public DateTime DateAndTime { get; set; }

        public List<Product> ReadProducts(string dataPath) //deducted from the data file
        {
           var reader = new StreamReader(File.OpenRead(dataPath));
            reader.ReadLine();
            var products = new List<Product>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                if (line != null)
                {
                    var values = line.Split(';');
                    var product = new Product
                    {
                        NameOfProduct = values[0],
                        NumberOfProduct = values[1],
                        PriceOfProduct = Convert.ToInt32(values[2]),
                        CategoryOfProduct = values[3],
                        DateAndTime = Convert.ToDateTime(values[4]),

                    };
                    products.Add(product);
                }

               
            }
            reader.Close();
            return products;
      

    }

         
        public void WriteProducts(List<Product> products,string path) 
        {
            
            File.WriteAllText(path, "NameOfProduct" + ";" + "NumberOfProduct" + ";" + "PriceOfProduct" + ";" +
                            "CategoryOfProduct" + ";" + "DateAndTime" + "\r\n");

            File.AppendAllLines(path, products.Select(p => p.NameOfProduct + ";" +
                                                                          p.NumberOfProduct + ";" +
                                                                          p.PriceOfProduct + ";" +
                                                                          p.CategoryOfProduct + ";" +
                                                                          p.DateAndTime));            

        }         

        }

        }
    

