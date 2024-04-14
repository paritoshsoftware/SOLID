using DesignPattern;
using Game;
using NullPointerException;
internal class Program
{
    private static void Main(string[] args)
    {
        VehicleFactory vehicleFactoryObject = new VehicleFactory("Car");
        var result = vehicleFactoryObject.GetVehicle();
        Console.WriteLine($"Vehicle Type  : {result.GetInformation()}");
        Console.WriteLine($"Vehicle Price : {result.GetPrice()}");
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