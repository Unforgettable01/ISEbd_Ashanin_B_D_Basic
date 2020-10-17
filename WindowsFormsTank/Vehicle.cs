using System.Drawing;

namespace WindowsFormsTank
{
    public abstract class Vehicle : ITransport
    {
        /// <summary>
        /// Левая координата отрисовки танка
        /// </summary>
        protected float _startPosX;
        /// <summary>
        /// Правая кооридната отрисовки танка
        /// </summary>
        protected float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        protected int _pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        protected int _pictureHeight;
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { protected set; get; }
        /// <summary>
        /// Вес танка
        /// </summary>
        public float Weight { protected set; get; }
        /// <summary>
        /// Основной цвет кузова
        /// </summary>
        public Color MainColor { protected set; get; }
        public void SetPosition(int x, int y, int width, int height)
        {
            _pictureHeight = height;
            _pictureWidth = width;
            _startPosX = x;
            _startPosY = y;
        }
        public abstract void DrawTransport(Graphics g);
        public abstract void MoveTransport(Direction direction);
    }
}
