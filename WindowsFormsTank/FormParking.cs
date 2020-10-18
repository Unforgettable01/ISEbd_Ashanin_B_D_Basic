using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsTank
{
    public partial class FormParking : Form
    {
        /// <summary>
        /// Объект от класса-парковки
        /// </summary>
        private readonly Parking<ArmoredVehicle> parking;

        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<ArmoredVehicle>(pictureBoxParking.Width,
           pictureBoxParking.Height);
            Draw();
        }
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать транспорт"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonParkingArmoredVehicle_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var armoredVehicle = new ArmoredVehicle(100, 1000, dialog.Color);

                if (parking + armoredVehicle)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Парковка переполнена");
                }
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать гоночный автомобиль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonParkingTank_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var armoredVehicle = new Tank(100, 1000, dialog.Color, dialogDop.Color,
                   true, true, true, true, true);
                    if (parking + armoredVehicle)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Парковка переполнена");
                    }
                }
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGetVehicle_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxParkingNumber.Text != "")
            {
                var armoredVehicle = parking - Convert.ToInt32(maskedTextBoxParkingNumber.Text);
                if (armoredVehicle != null)
                {
                    FormTank form = new FormTank();
                    form.SetArmoredVehicle(armoredVehicle);
                    form.ShowDialog();
                }
                Draw();
            }
        }


    }
}
