using System;
using System.Collections.Generic;

namespace Decorator{


    // Паттерн реализует класс-декторатор, сождержащий в себе объект базового класса
    // и позволяет последовательно расширять его функционал, создавая цепочку связанных объектов. 

    public class Example : Patterns.IPattern 
    {
        public string Name { get => "Decorator"; } 

        public void Run()
        {

            Beverage myTea = new BlackTea();

            myTea = new MilkDecorator(myTea);

            Console.WriteLine($"{myTea.Description}, cost ${myTea.Cost}");


            Beverage myCoffe = new SugarDecorator(new MilkDecorator(new SugarDecorator(new Coffe())));

            Console.WriteLine($"{myCoffe.Description}, cost ${myCoffe.Cost}");


        }

    }


 

}