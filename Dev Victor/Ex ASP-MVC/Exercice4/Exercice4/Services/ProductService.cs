using Exercice4.Interfaces;
using Exercice4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4.Services
{
    public class ProductService: IProductService
    {
        List<Product> products = new List<Product>()
        {
            new Product{Id=1, Name="Caramel", Category="Confiserie", Price=2.5},
            new Product{Id=2, Name="Cerise", Category="Fruit", Price=0.62},
            new Product{Id=3, Name="Banane", Category="Fruit", Price=0.4},
            new Product{Id=4, Name="Goyave", Category="Fruit", Price=7.5},
            new Product{Id=5, Name="Guimauve", Category="Confiserie", Price=3.5}
        };


        public void RecupererProduitParID(int id)
        {           
            
            for (int i = 0; i< products.Count; i++)
            {
                if (i == id)
                {
                    Console.WriteLine(products[id]);
                    continue;
                }
            }
        }

        public void RecupererTousLesProduits()
        {
            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }
        }

    }


}
