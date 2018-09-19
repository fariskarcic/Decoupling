using System;

namespace InterfacesDIDelegatesEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            var youngest = new YoungestSon();
            var eldest = new EldestSon();

            var dad = new Dad(eldest);
            dad.SeekHelpConstructorInjection("Need help");

            dad.SeekHelpMethodInjection(youngest, "Need help");

            dad.Son = eldest;
            dad.SeekHelpPropertyInjection("Help");

            /** Generics */
            Comparation<int> comparation = new Comparation<int>();
            bool b = comparation.CompareIfSame(10, 10);
            Console.WriteLine(b);

            /** Delegates */
            DelegateTest del = new DelegateTest();
            del.LongRunning(Callback);

            Console.ReadLine();
        }

        static void Callback(int num)
        {
            Console.WriteLine("Delegate passed value: {0}", num);
        }
    }
}
