using System;

namespace WindowsFormsTank
{
    [Serializable]
    internal class ParkingOccupiedPlaceException : Exception
    {
        
        public ParkingOccupiedPlaceException() : base("Не удалось припарковать")
        {
        }

    }
}