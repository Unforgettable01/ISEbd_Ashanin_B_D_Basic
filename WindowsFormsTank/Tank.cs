using System.Drawing;

namespace WindowsFormsTank
{
    class Tank
    {
        /// Левая координата отрисовки танка

        private float _startPosX;
        /// <summary>
        /// Правая кооридната отрисовки танка

        private float _startPosY;

        /// Ширина окна отрисовки

        private int _pictureWidth;

        /// Высота окна отрисовки

        private int _pictureHeight;

        /// Ширина отрисовки танка

        private readonly int carWidth = 290;

        /// Высота отрисовки танка

        private readonly int carHeight = 200;

        /// Максимальная скорость

        public int MaxSpeed { private set; get; }

        /// Вес танка

        public float Weight { private set; get; }

        /// Основной цвет кузова

        public Color MainColor { private set; get; }

        /// Дополнительный цвет

        public Color DopColor { private set; get; }

        /// Признак наличия правого щита

        public bool RightShield { private set; get; }

        /// Признак наличия переднего щита

        public bool FrontShield { private set; get; }

        /// Признак наличия левого щита

        public bool LeftShield { private set; get; }

        /// Признак доп.колеса и лента 

        public bool DopWheel { private set; get; }

        /// Признак большое орудие 

        public bool BigGun { private set; get; }


        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///


        /// Конструктор
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес танка</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="frontShield">Признак наличия переднего щита</param>
        /// <param name="sideShield">Признак наличия боковых щитов</param>
        /// <param name="backShield">Признак наличия заднего щита</param>

        public Tank(int maxSpeed, float weight, Color mainColor, Color dopColor,
       bool frontShield, bool leftShield, bool rightShield, bool dopWheel, bool bigGun)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            FrontShield = frontShield;
            LeftShield = leftShield;
            RightShield = rightShield;
            DopWheel = dopWheel;
            BigGun = bigGun;
        }

        /// Установка позиции танка
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height)
        {
            _pictureHeight =  height;
            _pictureWidth = width;
            _startPosX =  x;
            _startPosY =  y;
        }
        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                //вверх
                case Direction.Up:

                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }

                    break;
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - carWidth)
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
               

                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - carHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }





        /// <summary>
        /// Отрисовка танка
        /// </summary>
        /// <param name="g"></param>
        public void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);

            // правый щит
            if (RightShield)
            {
                Brush shield = new SolidBrush(DopColor);
                g.DrawRectangle(pen, _startPosX + 260, _startPosY + 50, 10, 90);// правый щит
                g.FillRectangle(shield, _startPosX + 260, _startPosY + 50, 10, 90);// правый щит

            }
            // левый щит
            if (LeftShield)
            {
                Brush shield = new SolidBrush(DopColor);
                g.DrawRectangle(pen, _startPosX, _startPosY + 50, 10, 90);// левый щит
                g.FillRectangle(shield, _startPosX, _startPosY + 50, 10, 90);// левый щит
            }
            // передний щит над гусеницами
            if (FrontShield)
            {
                Brush shield = new SolidBrush(DopColor);
                g.DrawRectangle(pen, _startPosX, _startPosY + 120, 270, 30);// передний  щит
                g.DrawRectangle(pen, _startPosX, _startPosY + 40, 75, 10);// верхний  щит, левая часть пред орудием
                g.DrawRectangle(pen, _startPosX + 165, _startPosY + 40, 105, 10);// верхний  щит, правая часть после орудия

                g.FillRectangle(shield, _startPosX, _startPosY + 120, 270, 30);// передний  щит
                g.FillRectangle(shield, _startPosX, _startPosY + 40, 75, 10);// верхний  щит, левая часть пред орудием
                g.FillRectangle(shield, _startPosX + 165, _startPosY + 40, 105, 10);// верхний  щит, правая часть после орудия
            }


            if (DopWheel)
            {
                g.DrawEllipse(pen, _startPosX, _startPosY + 140, 30, 30); // самое левое колесо №1
                g.DrawEllipse(pen, _startPosX + 80, _startPosY + 140, 50, 50); //  №3
                g.DrawEllipse(pen, _startPosX + 130, _startPosY + 140, 50, 50); //  №4
                g.DrawEllipse(pen, _startPosX + 230, _startPosY + 140, 30, 30); //  №6
                Pen penLenta = new Pen(Color.Black, 10);
                g.DrawEllipse(penLenta, _startPosX, _startPosY + 140, 280, 50); //  лента ++
                Brush brGreyWheel = new SolidBrush(Color.Gray);
                g.FillEllipse(brGreyWheel, _startPosX, _startPosY + 140, 30, 30); // самое левое колесо №1
                g.FillEllipse(brGreyWheel, _startPosX + 80, _startPosY + 140, 50, 50); //  №3
                g.FillEllipse(brGreyWheel, _startPosX + 130, _startPosY + 140, 50, 50); //  №4
                g.FillEllipse(brGreyWheel, _startPosX + 230, _startPosY + 140, 30, 30); //  №6
            }
            

            if (BigGun)
            {
                Brush mainColorGun = new SolidBrush(MainColor);
                g.DrawRectangle(pen, _startPosX - 20, _startPosY + 20, 95, 10);              //большое орудие
                g.FillRectangle(mainColorGun, _startPosX - 20, _startPosY + 20, 95, 10);    //большое орудие
            }
            // теперь отрисуем основной кузов танка          
            ///сам танк
            ///////////////////////////////////////////////////////////////////////////////////
            Brush mainColor = new SolidBrush(MainColor);
            g.DrawRectangle(pen, _startPosX + 75, _startPosY + 10, 90, 40);   //тело башни
            g.DrawRectangle(pen, _startPosX + 10, _startPosY + 50, 250, 90);  // основное тело танка
            g.FillRectangle(mainColor, _startPosX + 75, _startPosY + 10, 90, 40);   //тело башни
            g.FillRectangle(mainColor, _startPosX + 10, _startPosY + 50, 250, 90);  // основное тело танка
            Pen penSmallGun = new Pen(Color.Black, 5);
            g.DrawLine(penSmallGun, _startPosX + 165, _startPosY + 15, _startPosX+190, _startPosY+15);// малое орудие в бр.машине №1
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
    }
}
