using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BestPractice.API.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
    public class Order : ControllerBase
    {
        public string Code { get; set; }

        public List<OrderItem> Items { get; set; }

        public void AddItem(OrderItem item)
        {
            if (Items.Count >= 3)
            {
                throw new Exception("3ten fazla ürün sepete eklenemez");

            }

            Items.Add(item);

        }
    }
}
