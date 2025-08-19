using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Задание 1
//Создайте класс Пьеса. Класс должен хранить такую информацию:

//Название пьесы;
//ФИО автора;
//Жанр;
//Год выпуска.
//Реализуйте в классе методы и свойства, необходимые для функционирования класса. Добавьте в классе деструктор.
//Напишите код для тестирования функциональности класса.
//Напишите код для проверки работы деструктора (например, создание и удаление объектов).


namespace Garbage_collection.Task_1
{
    internal class Play(string title, string authorFullName, string genre, DateTime releaseYear) : IDisposable, IDispose
    {
        public string Title { get; set; } = title;
        public string AuthorFullName { get; set; } = authorFullName;
        public string Genre { get; set; } = genre;
        public DateTime ReleaseYear { get; set; } = releaseYear;

        private bool disposed = false;

        public void StartPlay() => Console.WriteLine($"Start play {Title}");

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected void Dispose(bool disposing)
        {
            if (disposed == true)
            {
                if (disposing == true)
                {
                    Console.WriteLine($"Пьеса подходит к концу");
                }

                Console.WriteLine($"The play {Title} is over, author {AuthorFullName} died");
            }

            disposed = true;
        }

        ~Play()
        {
            Console.WriteLine($"Уничтожение человечества произошло");
            Dispose(false);
        }
    }
}
