using Serenity.Services;

namespace OoapasDemo.Northwind {
    public class OrderListRequest : ListRequest {
        public int? ProductID { get; set; }
    }
}