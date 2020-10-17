using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsTank
{

    public partial class FormTank : Form
    {

        private ITransport armoredVihicle;
        private ArmoredVehicle armoredVehicle;

        /// <summary>
        /// Конструктор
        /// </summary>
        public FormTank()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод отрисовки 
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxTank.Width, pictureBoxTank.Height);
            Graphics gr = Graphics.FromImage(bmp);
            armoredVihicle.DrawTransport(gr);
            pictureBoxTank.Image = bmp;
        }
        /// <summary>
        /// Обработка нажатия кнопки "Создать бронированная машина"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateArmoredVehicle_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            armoredVihicle = new ArmoredVehicle(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Green);

            armoredVihicle.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxTank.Width,
           pictureBoxTank.Height);
            Draw();
        }
        /// <summary>
        /// Обработка нажатия кнопки "Создать гоночный автомобиль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateTank_Click_1(object sender, EventArgs e)
        {
            Random rnd = new Random();
            armoredVihicle = new Tank(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Green, Color.Brown, true, true, true, true, true);
            armoredVihicle.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxTank.Width,
           pictureBoxTank.Height);
            Draw();
        }
        /// <summary>
        /// Обработка нажатия кнопок управления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    armoredVihicle.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    armoredVihicle.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    armoredVihicle.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    armoredVihicle.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }


    }
}
