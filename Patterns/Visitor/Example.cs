using System;
using System.Collections.Generic;

namespace Patterns.Visitor{

    // Паттерн позволяет добавлять методы к классам, закрытым от изменения, но реализщующим интерфейс обработки посещения:
    // умеющим вызывать свой интерфейсный метод из набора методов посетителя
    // Посетителей может быть несколько, каждый реализует свой функционал
    // Плюсы: можно проходить по обобщенным коллекциям, вызывая метод

    public class Example : IPattern 
    {
        public string Name { get => "Visitor"; } 

        public void Run()
        {

            // Обобщенный список разных объектов, умеющих принимать посетителей
            List<Animal> animals = new List<Animal> {
                new Cat(),
                new Dog()
            };

            Console.WriteLine("Extend animals for say");

            // Объявляем посетителя, содержащего методы, реализующие конкретную логику для всех объектов
            // Например, способность издавать  звуки

            IVisitor say = new Say();

            // Дл япроверки функционала прогоняем его через все объекты
            foreach(var animal in animals)
                animal.Accept(say);             


            Console.WriteLine("Extend animals for scare");

            // Пример вызова другой догики
            IVisitor scare = new Scare();

            foreach(var animal in animals)
                animal.Accept(scare);             

        }

    }


 

}