namespace MyClass.Subscription;

// For basic subscription that allows to play only playlists without skipping tracks

public class FreeSubscription: ISubscriprion
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
        Console.WriteLine("You can listen playlists. You can't skip tracks.");
        Console.WriteLine($"For price {price}$");
    }

    public FreeSubscription()
    {
        name = "Free";
        price = 0.0;
    }
}