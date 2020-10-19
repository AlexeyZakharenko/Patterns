using System.Collections.Generic;

namespace Decorator {

    // Обобщенный класс декоратора, нужен для соглаосвания типов и хранения декорируемого объекта
    // Наследование необходимо, чтобы можно было приводить результат декорирования к исходному классу,
    // а композиция (включение экземпляра класса как члена класса) необходимо, чтобы построить цепочку расширения функционала
    public abstract class BeverageDecorator : Beverage
    {
        internal Beverage beverage;

        // В конструкторе получаем декорируемый объект и сохраняем его у себя
        public BeverageDecorator(Beverage _beverage)
        {
            beverage = _beverage;
        }

    } 


    // Добавляем в напиток молоко

    public class MilkDecorator: BeverageDecorator{
        
        public MilkDecorator(Beverage _beverage): base(_beverage) {}

        // Добавляем в описание, чем декорировали
        public override string Description => beverage.Description + " with milk";

        // И увеличиваем цену
        public override int Cost => beverage.Cost + 3;

    }

    // Еще один декоратор - добавим сахар

    public class SugarDecorator: BeverageDecorator{
        
        public SugarDecorator(Beverage _beverage): base(_beverage) {}

        // Добавляем в описание, чем декорировали
        public override string Description => beverage.Description + " with sugar";

        // И увеличиваем цену
        public override int Cost => beverage.Cost + 1;

    }


}