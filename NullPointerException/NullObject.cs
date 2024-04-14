
namespace NullPointerException
{
    internal class NullObject : IVehicle
    {
        public string GetInformation()
        {
           return string.Empty; 
        }

        public int GetPrice()
        {
            return 0;
        }
    }
}
