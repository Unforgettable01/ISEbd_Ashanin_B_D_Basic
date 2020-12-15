using System.Collections.Generic;

namespace WindowsFormsTank
{
    class TankComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x is ArmoredVehicle && y is ArmoredVehicle)
            {
                return ComparerArmoredVehicle((ArmoredVehicle)x, (ArmoredVehicle)y);
            }
            if (x is ArmoredVehicle && y is Tank)
            {
                return -1;
            }
            if (x is Tank && y is ArmoredVehicle)
            {
                return 1;
            }
            if (x is Tank && y is Tank)
            {
                return ComparerTank((Tank)x, (Tank)y);
            }
            return 0;
        }

        private int ComparerArmoredVehicle(ArmoredVehicle x, ArmoredVehicle y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }

        private int ComparerTank(Tank x, Tank y)
        {
            var res = ComparerTank(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.FrontShield != y.FrontShield)
            {
                return x.FrontShield.CompareTo(y.FrontShield);
            }
            if (x.LeftShield != y.LeftShield)
            {
                return x.LeftShield.CompareTo(y.LeftShield);
            }
            if (x.RightShield != y.RightShield)
            {
                return x.RightShield.CompareTo(y.RightShield);
            }
            if (x.DopWheel != y.DopWheel)
            {
                return x.DopWheel.CompareTo(y.DopWheel);
            }
            if (x.BigGun != y.BigGun)
            {
                return x.BigGun.CompareTo(y.BigGun);
            }
            return 0;
        }
    }
}
