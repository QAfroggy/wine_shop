public class Cart
{
    public User Customer { get; set; }
    public Cart(User customer)
    {
        Customer = customer;
    }
    public List<CartItem> Items { get; private set; } = new List<CartItem>();









}