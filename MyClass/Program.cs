using MyClass.Subscription;

namespace Lab_6;

class Program
{
    private MyClass factory = new MyClass();
    static void Main(string[] args)
    {
        PremiumSubscription premium = MyClass.FacrotyMethod<PremiumSubscription>();
        premium.GetDescriprion();
    }
}
