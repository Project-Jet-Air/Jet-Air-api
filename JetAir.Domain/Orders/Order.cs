using System.Collections.Generic;
using System.Linq;

namespace JetAir.Domain.Orders
{
    public class Order
    {
    public int Id { get; set; }
    public List<orderItem> Items { get; set; }
    public DateTime CreatedDate { get; set; }
    public decimal TotalPrice => Items.Sum(i => i.Price);

}

    public class orderItem
    {
    }
}