using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Задание 2
//Создайте класс Магазин
//Класс должен хранить такую информацию:

//Название магазина;
//Адрес магазина;
//Тип магазина:
//Продовольственный;
//Хозяйственный;
//Одежда;
//Обувь

//Реализуйте в классе методы и свойства, необходимые для функционирования класса.
//Класс должен реализовывать интерфейс IDisposable. Напишите код для тестирования функциональности класса.
//Напишите код для вызова метода Dispose.


namespace Garbage_collection.Task_2
{
    internal class Store (string name, string adress, string type) : IDisposable
    {
        public string Name { get; set; } = name;
        public string Adress { get; set; } = adress;
        public string Type { get; set; } = type;


        private bool disposed = false;


        public void Sales() => Console.WriteLine("Магазин открылся");

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected void Dispose(bool disposing)
        {
            if (disposed)
            {
                if (disposing) {
                    Console.WriteLine("Произошло убийство");
                }

                Console.WriteLine("Магазин закрыт, до выяснения того что убийца - дворецкий");
            }
        }

        ~Store()
        {
            Console.WriteLine("Дворецкого не нашли");
            Dispose(false);
        }
    }
}
