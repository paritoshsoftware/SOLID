namespace NullPointerException
{
    internal class Car : IVehicle
    {
        public string GetInformation()
        {
            return "This is Four Seater Car.";

        }

        public int GetPrice()
        {
            return 1500000;
        }
    }
}
