
interface ITarget
{
    void Request();
}

// class you want to adapt
class Adaptee
{
    public void SpecificRequest()
    {
        Console.WriteLine("Adaptee'srequest.");
    }
}


class Adapter : ITarget
{
    private Adaptee adaptee;

    public Adapter(Adaptee adaptee)
    {
        this.adaptee = adaptee;
    }

    public void Request()
    {
        adaptee.SpecificRequest();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Adaptee adaptee = new Adaptee();

        var adapter = new Adapter(adaptee);

        adapter.Request();

        Console.ReadLine();
    }
}
