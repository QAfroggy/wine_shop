public class User
{
    public string Name { get; set; }
    public int Age { get; set; }
    public bool IsAdult => Age >= 18;
}