namespace MyClass.Subscription;

/*
 * Interface for different subscription levels
 * It makes to implement:
 *      - 'Name' property for the name of the subscription
 *      - 'Price' property for the price of the subscription
 *      - 'GetDescription' method to count and output the price of the subscription
 */

public interface ISubscriprion
{
     public string Name { get;  }
     public double Price { get;  }

     public void GetDescriprion();
}