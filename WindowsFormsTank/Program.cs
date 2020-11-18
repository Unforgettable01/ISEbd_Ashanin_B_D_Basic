using System;

using System.Windows.Forms;

namespace WindowsFormsTank
{
    public delegate void VehicleDelegate(Vehicle vehicle);
    static class Program
    {
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormParking());
        }
    }
}
