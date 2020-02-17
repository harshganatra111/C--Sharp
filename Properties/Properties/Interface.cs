using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    interface IMeter
    {
        void Print();
    }
    class meter : IMeter
    {
        public void print()
        {
            Console.WriteLine("jxszdhfjsdhyvfbdskiuyj");
        }

        public void Print()
        {
            throw new NotImplementedException();
        }
    }

    class Interface
    {
        static void Main(string[] args)
        {

            meter obj = new meter();
            obj.print();
            Console.ReadKey();
        }
    }
}
