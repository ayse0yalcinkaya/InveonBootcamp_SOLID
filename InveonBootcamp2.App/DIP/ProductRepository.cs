using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InveonBootcamp2.App.DIP
{
    
    internal class ProductRepository:IProductRepository
    {
        public static int kdv = 20;

        public List<Product> GetAll()
        {
            //return product list
            return
            [
                new Product{Id=1, Price=100},
                new Product{Id=2, Price=200},
                new Product{Id=3, Price = 300}
            ];
        }
    }
}
