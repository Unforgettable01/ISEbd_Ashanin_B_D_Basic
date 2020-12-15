using System;
using System.Drawing;
namespace WindowsFormsTank
{
    public class ArmoredVehicle : Vehicle, IEquatable<ArmoredVehicle>

    {
        /// <summary>
        /// Ширина отрисовки танка
        /// </summary>
        protected readonly int armoredVehicleWidth = 290;
        /// <summary>
        /// Высота отрисовки танка
        /// </summary>
        protected readonly int armoredVehicleHeight = 200;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// 

        protected readonly char separator = ';';


        /// <summary>
        /// Конструктор для загрузки с файла
        /// </summary>
        /// <param name="info">Информация по объекту</param>
        public ArmoredVehicle(string info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        public ArmoredVehicle(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        /// <summary>
        /// Конструкторс изменением размеров брон.машины
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес брон.машины</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="carWidth">Ширина отрисовки брон.машины</param>
        /// <param name="carHeight">Высота отрисовки брон.машины</param>
        protected ArmoredVehicle(int maxSpeed, float weight, Color mainColor, int carWidth, int
       carHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.armoredVehicleWidth = carWidth;
            this.armoredVehicleHeight = carHeight;
        }

        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Up:

                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }

                    break;
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - armoredVehicleWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:

                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }

                    break;
                //вверх

                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - armoredVehicleHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            // теперь отрисуем основной кузов танка          
            ///сам танк
            ///////////////////////////////////////////////////////////////////////////////////
            Brush mainColor = new SolidBrush(MainColor);
            g.DrawRectangle(pen, _startPosX + 75, _startPosY + 10, 90, 40);   //тело башни
            g.DrawRectangle(pen, _startPosX + 10, _startPosY + 50, 250, 90);  // основное тело танка
            g.FillRectangle(mainColor, _startPosX + 75, _startPosY + 10, 90, 40);   //тело башни
            g.FillRectangle(mainColor, _startPosX + 10, _startPosY + 50, 250, 90);  // основное тело танка
            Pen penSmallGun = new Pen(Color.Black, 5);
            g.DrawLine(penSmallGun, _startPosX + 165, _startPosY + 15, _startPosX + 190, _startPosY + 15);// малое орудие в бр.машине №1
            Pen penGun = new Pen(Color.Black, 3);
            g.DrawLine(penGun, _startPosX + 225, _startPosY + 35, _startPosX + 280, _startPosY + 35);// малое орудие в бр.машине №2 горизонтальная часть
            g.DrawLine(penGun, _startPosX + 225, _startPosY + 35, _startPosX + 225, _startPosY + 50);// малое орудие в бр.машине №2 вертикальная часть
            ///////////////////////////отрисовка колес
            Brush brGray = new SolidBrush(Color.Gray);
            g.DrawEllipse(pen, _startPosX + 30, _startPosY + 140, 50, 50); // колесо от бр.машины №1  в танке №2           
            g.DrawEllipse(pen, _startPosX + 180, _startPosY + 140, 50, 50); // колесо от бр.машины №2  в танке №5

            g.FillEllipse(brGray, _startPosX + 30, _startPosY + 140, 50, 50); //  колесо от бр.машины №1  в танке №2           
            g.FillEllipse(brGray, _startPosX + 180, _startPosY + 140, 50, 50); //  колесо от бр.машины №2  в танке №5        
        }

        public override string ToString()
        {
            return $"{MaxSpeed}{separator}{Weight}{separator}{MainColor.Name}";
        }

        /// <summary>
        /// Метод интерфейса IEquatable для класса ArmoredVehicle
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(ArmoredVehicle other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is ArmoredVehicle armoredVehicleObj))
            {
                return false;
            }
            else
            {
                return Equals(armoredVehicleObj);
            }
        }
    }
}
