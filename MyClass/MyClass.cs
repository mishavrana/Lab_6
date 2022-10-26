using MyClass.Subscription;

namespace Lab_6;

public class MyClass
{
    public static ISubscriprion FacrotyMethod<ISubscriprion>() where ISubscriprion : new()
    {
        return new ISubscriprion();
    }
}