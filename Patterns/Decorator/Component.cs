
namespace Decorator{
    

    // Базовый класс, который будем декорировать
    // Пусть это будут напитки, в которые можно добавлять разное
    public abstract class Beverage{

        public virtual string Description { get; }

        public virtual int Cost { get; }
    }

    // Реализация напитка
    public class BlackTea: Beverage{

        public override string Description { get => "Black tea"; }
        public override int Cost { get => 5; }

    }


    // Еще один напиток
    public class Coffe: Beverage{

        public override string Description { get => "Coffe"; }
        public override int Cost { get => 7; }

    }


}