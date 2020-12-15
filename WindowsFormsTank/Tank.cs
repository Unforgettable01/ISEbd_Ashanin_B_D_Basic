using System;
using System.Drawing;

namespace WindowsFormsTank
{
    public class Tank : ArmoredVehicle, IEquatable<Tank>
    {

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

        public Tank(int maxSpeed, float weight, Color mainColor, Color dopColor, bool frontShield, bool leftShield, bool rightShield, bool dopWheel, bool bigGun) :
            base(maxSpeed, weight, mainColor, 290, 200)
        {
            DopColor = dopColor;
            FrontShield = frontShield;
            LeftShield = leftShield;
            RightShield = rightShield;
            DopWheel = dopWheel;
            BigGun = bigGun;
        }

        /// <summary>
        /// Конструктор для загрузки с файла
        /// </summary>
        /// <param name="info"></param>
        public Tank(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 9)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                FrontShield = Convert.ToBoolean(strs[4]);
                LeftShield = Convert.ToBoolean(strs[5]);
                RightShield = Convert.ToBoolean(strs[6]);
                DopWheel = Convert.ToBoolean(strs[7]);
                BigGun = Convert.ToBoolean(strs[8]);
            }
        }


      
        /// <summary>
        /// Отрисовка танка
        /// </summary>
        /// <param name="g"></param>
        public override void DrawTransport(Graphics g)
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
            base.DrawTransport(g);
        }

        /// <summary>
        /// Смена дополнительного цвета
        /// </summary>
        /// <param name="color"></param>
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override string ToString()
        {
            return
           $"{base.ToString()}{separator}{DopColor.Name}{separator}{FrontShield}{separator}{LeftShield}{separator}{RightShield}{ separator}{DopWheel}{separator}{BigGun}";
        }

        /// <summary>
        /// Метод интерфейса IEquatable для класса Tank
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Tank other)
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
            if (!(obj is Tank tankObj))
            {
                return false;
            }
            else
            {
                return Equals(tankObj);
            }
        }
    }
}
