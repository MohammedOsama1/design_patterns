
using System.Reflection.PortableExecutable;

class pro
{


public static void Main(string[] args) {

       var gg = Singleton.Instance ;
       var gg2 = Singleton.Instance ;
       var gg3 = Singleton.Instance ;

    }
}


class Singleton
{

    int num = 0;
    private Singleton()
    {
        num++;
        Thread.Sleep(2000);
        Console.WriteLine($"{num} hello norm");
    }

    private static object _lock = new object(); 

    private static Singleton? _instance;
    public static Singleton Instance {

        get
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
            }
            return _instance;

        }

    }

}