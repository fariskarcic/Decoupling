using System;

namespace InterfacesDIDelegatesEvents
{


    interface ISon
    {
        void Help(string message);
    }

    class YoungestSon : ISon
    {
        public void Help(string message)
        {
            Console.WriteLine("Youngest son is helping...");
        }
    }

    class EldestSon : ISon
    {
        public void Help(string message)
        {
            Console.WriteLine("Eldest son is helping...");
        }
    }


    class Dad
    {
        ISon son = null;

        /** Constructor injection */
        public Dad(ISon selectedSon)
        {
            son = selectedSon;
        }

        public void SeekHelpConstructorInjection(string message)
        {
            son.Help(message);
        }

        /** Method injection */
        public void SeekHelpMethodInjection(ISon sonCI, string message)
        {
            sonCI.Help(message);
        }

        /** Property injection */
        public ISon Son { get; set; }

        public void SeekHelpPropertyInjection(string message)
        {
            Son.Help(message);
        }
    }

    /** Generics */
    class Comparation<AnyDataType>
    {
        //AnyDataType data1;
        //AnyDataType data2;

        //public Comparation(AnyDataType rData1, AnyDataType rData2)
        //{
        //    data1 = rData1;
        //    data2 = rData2;
        //}

        public bool CompareIfSame(AnyDataType data1, AnyDataType data2)
        {
            if (data1.Equals(data2))
                return true;

            return false;
        }
    }

    class DelegateTest
    {
        public delegate void CallBack(int count);

        public void LongRunning(CallBack cb)
        {
            int count = 0;

            for (var i = 0; i < 1000; i++)
            {
                if ((i % 10) == 0)
                {
                    count++;
                }
            }

            cb(count);
        }
    }
}
