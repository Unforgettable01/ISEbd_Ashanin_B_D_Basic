using System;
using System.Runtime.Serialization;

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