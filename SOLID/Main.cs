using DesignPattern;
using Game;
internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            var dbObject =  GetDb();

            if(dbObject!=null) { Console.WriteLine("Connected  To DB"); }

        }catch (Exception ex)
        {
            Console.WriteLine(ex.Message.ToString());   
        }

    }

    public static  Database GetDb()
    {
        var database = Database.Builder().
            Host("5822").
            Port(5000).
            UserName("paritosh").
            PassWord("password@123").
            Build();

        return database;

    }
}