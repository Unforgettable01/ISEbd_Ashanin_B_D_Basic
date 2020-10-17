using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsTank
{

    public partial class FormTank : Form
    {

        private Tank tank;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// 

        public FormTank()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод отрисовки танка
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxTank.Width, pictureBoxTank.Height);
            Graphics gr = Graphics.FromImage(bmp);
            tank.DrawTransport(gr);
            pictureBoxTank.Image = bmp;
        }

        /// <summary>
        /// Обработка нажатия кнопки "Создать"
        /// </summary>

        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            tank = new Tank(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Green,Color.Brown, true, true, true, true,true);
            tank.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxTank.Width,
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
                    tank.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    tank.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    tank.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    tank.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }


    }


}