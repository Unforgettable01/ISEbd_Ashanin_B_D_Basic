using NLog;
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
        private readonly ParkingCollection parkingCollection;

        private readonly Logger logger;

        public FormParking()
        {
            InitializeComponent();
            parkingCollection = new ParkingCollection(pictureBoxParking.Width, pictureBoxParking.Height);
            logger = LogManager.GetCurrentClassLogger();
        }



        /// Заполнение listBoxLevels
        /// </summary>
        private void ReloadLevels()
        {
            int index = listBoxParkings.SelectedIndex;
            listBoxParkings.Items.Clear();
            for (int i = 0; i < parkingCollection.Keys.Count; i++)
            {
                listBoxParkings.Items.Add(parkingCollection.Keys[i]);
            }
            if (listBoxParkings.Items.Count > 0 && (index == -1 || index >= listBoxParkings.Items.Count))
            {
                listBoxParkings.SelectedIndex = 0;
            }
            else if (listBoxParkings.Items.Count > 0 && index > -1 && index < listBoxParkings.Items.Count)
            {
                listBoxParkings.SelectedIndex = index;
            }
        }

        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parkingCollection[listBoxParkings.SelectedItem.ToString()].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }


        /// <summary>
        /// Обработка нажатия кнопки "Добавить парковку"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonAddParking_Click1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNumberParking.Text))
            {
                MessageBox.Show("Введите название парковки", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            logger.Info($"Добавили парковку {textBoxNumberParking.Text}");
            parkingCollection.AddParking(textBoxNumberParking.Text);
            ReloadLevels();
        }
        /// <summary>
        /// Обработка нажатия кнопки "Удалить парковку"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelParking_Click1(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить парковку { listBoxParkings.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo,
           MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    logger.Info($"Удалили парковку { listBoxParkings.SelectedItem.ToString() }");
                    parkingCollection.DelParking(textBoxNumberParking.Text);
                    ReloadLevels();
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
            if (listBoxParkings.SelectedIndex > -1 && maskedTextBoxParkingNumber.Text != "")
            {
                try
                {
                    var vehicle = parkingCollection[listBoxParkings.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxParkingNumber.Text);
                    if (vehicle != null)
                    {
                        FormTank form = new FormTank();
                        form.SetArmoredVehicle(vehicle);
                        form.ShowDialog();
                        logger.Info($"Изъят транспорт {vehicle} с места  { maskedTextBoxParkingNumber.Text} ");
                        Draw();
                    }
                }
                catch (ParkingNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //logger.Warn($"{ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //logger.Warn($"{ex.Message}");
                }
            }

        }

        private void listBoxParkings_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Info($"Перешли на парковку { listBoxParkings.SelectedItem.ToString()}");

            Draw();
        }

        /// <summary>
        /// Обработка нажатия кнопки "Добавить автомобиль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddVehicle_Click(object sender, EventArgs e)
        {
            var formTankConfig = new FormTankConfig();
            formTankConfig.AddEvent(AddVehicle);
            formTankConfig.Show();
        }
        /// <summary>
        /// Метод добавления машины
        /// </summary>
        /// <param name="vehicle"></param>
        private void AddVehicle(Vehicle vehicle)
        {
            if (vehicle != null && listBoxParkings.SelectedIndex > -1)
            {
                try
                {
                    if ((parkingCollection[listBoxParkings.SelectedItem.ToString()]) + vehicle)
                    {
                        Draw();
                        logger.Info($"Добавлен транспорт {vehicle}");
                    }
                    else
                    {
                        MessageBox.Show("Транспорт не удалось поставить");
                        logger.Warn("Транспорт не удалось поставить");
                    }
                }
                catch (ParkingOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                    logger.Warn($"{ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn($"{ex.Message}");
                }

            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    parkingCollection.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn($"{ex.Message}");
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    parkingCollection.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                    ReloadLevels();
                    Draw();
                }
                catch (ParkingOccupiedPlaceException ex)
                {
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}