
namespace Visitor{
    
    // Интерфейс, котоорый должен быть реализован в классе каждого расширяемого объекта
    // Позволяет принять посетителя, реализующий определенный функционал
    public interface IComponent{
        public void Accept(IVisitor visitor);
    }

    // Различные классы, которые надо расширять
    // Могут не иметь общего родителя, но должны уметь приянть посетителя
    public class Cat: Animal, IComponent {

        public override string Name { get => "Cat"; }

        // В реализации интерфейсного метода вызываем у посетителя метод с нужной сигнатутрой
        // В нашем примере достаточно передать себя
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

    }


    // Более другой компонент
    public class Dog: Animal, IComponent {

        public override string Name { get => "Dog"; }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

    }

    // Общий родитель предыдущих классов. Служит для демонстрации того,
    // как паттерн работает, когда используются перегруженные функции реализации интерфейса
    public abstract class Animal: IComponent {

        public virtual string Name { get => "Animal"; }

        public abstract void Accept(IVisitor visitor);

    }


    // Компонент, не унаследованный от Animal, но также расширяемый посетителем
    public class Human: IComponent
    {
        public void Accept(IVisitor visitor){
            visitor.Visit(this);
        }

    }

}