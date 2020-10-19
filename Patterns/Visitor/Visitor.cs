using System;

namespace Visitor {

    // Интерфейс, содержит сигнатуры "посещающих" методов для всех обрабатываемых классов
    public interface IVisitor {

        // В принципе можно использовать для каждого типа свое имя метода, например
        // VistCat, VisitDog, но компилятор по сигнатуре определит, для какого типа какой метод надо вызввать

        public void Visit(Cat cat);

        public void Visit(Dog dog);

        public void Visit(Human human);

    }

    // Реализации конкретных визитеров
    // Именно в их методах реализуется логика, расширяющая объекты

    public class Say : IVisitor{

        public void Visit(Cat cat)
        {
            Console.WriteLine($"{cat.Name} meows");
        }

        public void Visit(Dog dog)
        {
            Console.WriteLine($"{dog.Name} barks");
        }

        public void Visit(Human human)
        {
            Console.WriteLine($"Human says 'Hello'");
        }

    }

    public class Scare : IVisitor{

        public void Visit(Cat cat)
        {
            Console.WriteLine($"{cat.Name} climbs to the tree");
        }

        public void Visit(Dog dog)
        {
            Console.WriteLine($"{dog.Name} runs away");
        }

        public void Visit(Human human)
        {
            Console.WriteLine($"Human screamed");
        }

    }

}