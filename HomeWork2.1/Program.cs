using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {       
            {
                string FullName = "Ходаков Денис Анатольевич";                     // Фамилия Имя Отчество
                byte age = 32;                                                    // Возраст
                string Email = "denis5517@yandex.ru";                             // Электронная почта
                double PointsIT = 99.9;                                           // Баллы по программированию
                double PointsMaths = 49.9;                                        // Баллы по математике
                double PointsPhysics = 39.5;                                      // Баллы по физике

                string newPattern = "ФИО: {0} \nВозраст: {1} \nПочта: {2} \nБаллы Программирование:" +
                    " {3} \nБаллы Математика: {4} \nБаллы Физика: {5}";
                Console.WriteLine(newPattern,
                    FullName,
                    age,
                    Email,
                    PointsIT,
                    PointsMaths,
                    PointsPhysics);
                Console.ReadKey();



            }
        }
    }
}
