namespace MyClass.Subscription;

// For premium subscription that allows to use any features
public class PremiumSubscription: ISubscriprion
{
    private string name;
    private double price;

    public string Name
    {
        get { return name; }
    }

    public double Price
    {
        get { return price; }
    }

    public void GetDescriprion()
    {
        Console.WriteLine($"The {name} subscription"); 
        Console.WriteLine("You can use any features");
        Console.WriteLine($"For price {price}$");
    }

    public PremiumSubscription()
    {
        name = "Premium";
        price = 5.0;
    }
}