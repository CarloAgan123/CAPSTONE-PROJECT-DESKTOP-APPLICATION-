using System.Collections.Generic;

namespace CAPSTONE_STOLE_ADMIN
{
    internal class Product
    {
        public string name { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }
        public string subTotalPrice { get; set; }
    }

    internal class OrderDetails
    {
        public string orderId { get; set; }
        public List<Product> products { get; set; }

        public string stallID {get; set; }
        public string type { get; set; }
        public string orderStatus { get; set; }
        public string orderDate { get; set; }
        public string orderTime { get; set; }
        public string paid { get; set; }
        public string totalPrice { get; set; }
        public string paymentMethod { get; set; }

        public OrderDetails()
        {
            products = new List<Product>();
        }
    }
}
