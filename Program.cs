using System;
using System.Collections.Generic;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IPattern> patterns = new List<IPattern>{
                new Visitor.Example(),
                new Decorator.Example()

            };

            foreach (var pattern in patterns)
            {
                Console.WriteLine( $"Run pattern '{pattern.Name}'");
                pattern.Run();
                Console.WriteLine();
            }



        }
    }
}
