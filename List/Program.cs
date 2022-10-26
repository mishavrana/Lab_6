namespace Lab_6;

class Program
{
    static MyList<string> values  = new MyList<string>();
    static void Main(string[] args)
    {
        values.AppendAt("BMW", 0);
        values.AppendAt("Mercedes", 1);
        values.AppendAt("KIA", 2);

        values.GetArray();
    }
}
