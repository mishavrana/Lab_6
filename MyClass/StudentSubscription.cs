namespace MyClass.Subscription;

// For premium subscription that allows to use any features for lower price
public class StudentSubscription: ISubscriprion
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

    public StudentSubscription()
    {
        name = "Student";
        price = 2.50;
    }
}