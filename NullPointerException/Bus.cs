namespace NullPointerException
{
    internal class Bus : IVehicle
    {
        public string GetInformation()
        {
            return "This is Volvo Bus.";
        }

        public int GetPrice()
        {
            return 9000000;
        }
    }
}
