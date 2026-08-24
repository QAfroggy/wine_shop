public class CartItem
{
    public Wine Wine { get; set; }
    public int Quantity { get; set; }
    public decimal TotalPrice => Wine.Price * Quantity;
}