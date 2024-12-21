using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InveonBootcamp2.App.DIP
{ //high level low level'a bağlı olmayacak  ProductService(ProductRepository) direkt kullanma arada yastık
    internal class Product
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
    }
}
