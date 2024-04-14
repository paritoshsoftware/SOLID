namespace NullPointerException
{
    internal class Bike : IVehicle
    {
        public string GetInformation()
        {
            return "This is 200CC Bike.";
        }

        public int GetPrice()
        {
            return 100000;
        }
    }
}
