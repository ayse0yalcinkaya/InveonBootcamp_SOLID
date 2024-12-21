using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InveonBootcamp2.App
{//yani genel isterfaceler verme yain soyutlama
    //webclient => read
    //mobile client => write

    public interface IReadRepository
    {
        void GetProduct();
        void GetProduct(int id);
    }

    public interface IWriteRepository 
    {
        void AddProduct();
        void UpdateProduct();
        void DeleteProduct();
    }

    public interface IXRepository
    {
        void GetProduct();
        void AddProduct();
    }


    public class ProductRepository : IWriteRepository, IReadRepository, IXRepository
    {
        public void AddProduct()
        {
            Console.WriteLine("p added");
        }

        public void UpdateProduct() { Console.WriteLine("p updated"); }

        public void DeleteProduct() { Console.WriteLine("p deleted"); }
        public void GetProduct(int id) { Console.WriteLine("ps getted"); }

        public void GetProduct()
        {
            Console.WriteLine("p getted");
        }
    }
}
