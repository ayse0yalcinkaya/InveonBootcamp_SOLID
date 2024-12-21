using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InveonBootcamp2.App.DIP
{ //service katmanından çağıracak olan yer
    //DataAccess
    internal class ProductController
    {
        public ProductService productService = new ProductService();
        public List<Product> GetAll()
        {
            return productService.GetAll();
        }
    }
}
