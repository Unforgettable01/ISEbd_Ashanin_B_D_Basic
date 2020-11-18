using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsTank
{
    public partial class FormTankConfig : Form
    {
        /// <summary>
        /// Переменная-выбранная машина
        /// </summary>
        Vehicle vehicle = null;

        private event VehicleDelegate eventAddVehicle;

        public FormTankConfig()
        {
            InitializeComponent();

            buttonCancle.Click += (object sender, EventArgs e) => { Close(); };
        }
        /// <summary>
        /// Отрисовать машину
        /// </summary>
        private void DrawVehicle()
        {
            if (vehicle != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxForDisplayVehicle.Width, pictureBoxForDisplayVehicle.Height);
                Graphics gr = Graphics.FromImage(bmp);
                vehicle.SetPosition(5, 5, pictureBoxForDisplayVehicle.Width, pictureBoxForDisplayVehicle.Height);
                vehicle.DrawTransport(gr);
                pictureBoxForDisplayVehicle.Image = bmp;
            }
        }

        /// <summary>
        /// Добавление события
        /// </summary>
        /// <param name="ev"></param>
        public void AddEvent(VehicleDelegate ev)
        {
            if (eventAddVehicle == null)
            {
                eventAddVehicle = new VehicleDelegate(ev);
            }
            else
            {
                eventAddVehicle += ev;
            }
        }

        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelArmoredVehicle_MouseDown(object sender, MouseEventArgs e)
        {
            labelArmoredVehicle.DoDragDrop(labelArmoredVehicle.Text, DragDropEffects.Move |
           DragDropEffects.Copy);
        }
        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelTank_MouseDown(object sender, MouseEventArgs e)
        {
            labelTank.DoDragDrop(labelTank.Text, DragDropEffects.Move |
           DragDropEffects.Copy);
        }
        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelForPictureBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        

        /// <summary>
        /// Действия при приеме перетаскиваемой информации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelForPictureBox_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Брон.машина":

                    vehicle = new ArmoredVehicle((int)numericUpDown_MaxSpeed.Value, (int)numericUpDown_WeightVehicle.Value, Color.White);
                    break;
                case "Танк":
                    vehicle = new Tank((int)numericUpDown_MaxSpeed.Value,
                   (int)numericUpDown_WeightVehicle.Value, Color.White, Color.Black, CheckBoxFrontShield.Checked, checkBoxSideShield.Checked, checkBoxBackShield.Checked, checkBoxDopWheel.Checked, checkBoxTopGun.Checked);
                    break;
            }
            DrawVehicle();
        }
        /// <summary>
        /// Отправляем цвет с панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            // Прописать логику вызова dragDrop для панелей, используя sender
        }
        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            // Прописать логику проверки приходящего значения на тип Color
        }
        /// <summary>
        /// Принимаем основной цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            // Прописать логику смены базового цвета
        }
        /// <summary>
        /// Принимаем дополнительный цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            // Прописать логику смены дополнительного цвета, если объект является объектом дочернего класса
        }
    }
}
