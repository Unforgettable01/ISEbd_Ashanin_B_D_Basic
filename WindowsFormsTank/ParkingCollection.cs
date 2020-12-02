using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WindowsFormsTank
{
    /// <summary>
    /// Класс-коллекция парковок
    /// </summary>
    public class ParkingCollection
    {
        /// <summary>
        /// Словарь (хранилище) с парковками
        /// </summary>
        readonly Dictionary<string, Parking<Vehicle>> parkingStages;
        /// <summary>
        /// Возвращение списка названий праковок
        /// </summary>
        public List<string> Keys => parkingStages.Keys.ToList();
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int pictureWidth;

        /// <summary>
        /// Разделитель для записи информации в файл
        /// </summary>
        private readonly char separator = ':';

        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int pictureHeight;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public ParkingCollection(int pictureWidth, int pictureHeight)
        {
            parkingStages = new Dictionary<string, Parking<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }
        /// <summary>
        /// Добавление парковки
        /// </summary>
        /// <param name="name">Название парковки</param>
        public void AddParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                return;
            }
            parkingStages.Add(name, new Parking<Vehicle>(pictureWidth, pictureHeight));
        }
        /// <summary>
        /// Удаление парковки
        /// </summary>
        /// <param name="name">Название парковки</param>
        public void DelParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                parkingStages.Remove(name);
            }
        }
        /// <summary>
        /// Доступ к парковке
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public Parking<Vehicle> this[string ind]
        {
            get
            {
                if (parkingStages.ContainsKey(ind))
                {
                    return parkingStages[ind];
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Метод записи информации в файл
        /// </summary>
        /// <param name="text">Строка, которую следует записать</param>
        /// <param name="stream">Поток для записи</param>
        /// 

        //private void WriteToFile(string text, FileStream stream)
        //{
        //    byte[] info = new UTF8Encoding(true).GetBytes(text);
        //    stream.Write(info, 0, info.Length);
        //}


        /// <summary>
        /// Сохранение информации по автомобилям на парковках в файл
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        /// <returns></returns>
        public void SaveData(string filename)
        {

            if (File.Exists(filename))
            {
                File.Delete(filename);
            }     
            using (StreamWriter sw = new StreamWriter(filename, true))
            {
                sw.Write($"ParkingCollection{Environment.NewLine}");
                foreach (var level in parkingStages)
                {
                    //начинаем парковку
                    sw.Write($"Parking{separator}{level.Key}{Environment.NewLine}");
                    ITransport vehicle = null;
                    for (int i = 0; (vehicle = level.Value.GetNext(i)) != null; i++)
                    {
                        if (vehicle != null)
                        {
                            //если у нас место не пустое тогда мы записываем тип машины                   
                            if (vehicle.GetType().Name == "ArmoredVehicle")
                            {
                                sw.Write($"ArmoredVehicle{separator}");
                            }
                            if (vehicle.GetType().Name == "Tank")
                            {
                                sw.Write($"Tank{separator}");
                            }
                            //запись параметров
                            sw.Write(vehicle + Environment.NewLine);
                        }
                    }
                }
            }

        }

        /// <summary>
        /// Загрузка информации по автомобилям на парковках из файла
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public void LoadData(string filename)
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                Vehicle vehicle = null;
                string line = sr.ReadLine();
                string key = string.Empty;

                if (!File.Exists(filename))
                {
                    throw new FileNotFoundException();
                }

                if (line.Contains("ParkingCollection"))
                {
                    parkingStages.Clear();
                    line = sr.ReadLine();
                    while (line != null)
                    {
                        if (line.Contains("Parking"))
                        {
                            key = line.Split(separator)[1];
                            parkingStages.Add(key, new Parking<Vehicle>(pictureWidth, pictureHeight));
                            line = sr.ReadLine();
                            continue;
                        }
                        if (string.IsNullOrEmpty(line))
                        {
                            line = sr.ReadLine();
                            continue;
                        }
                        if (line.Split(separator)[0] == "ArmoredVehicle")
                        {
                            vehicle = new ArmoredVehicle(line.Split(separator)[1]);
                        }
                        else if (line.Split(separator)[0] == "Tank")
                        {
                            vehicle = new Tank(line.Split(separator)[1]);
                        }
                        var result = parkingStages[key] + vehicle;
                        if (!result)
                        {
                            throw new Exception("Не удалось загрузить автомобиль на парковку");
                        }
                        line = sr.ReadLine();
                    }

                }
                else
                {
                    //если нет такой записи, то это не те данные
                    throw new Exception("Неверный формат файла");
                }

            }

        }
    }

}