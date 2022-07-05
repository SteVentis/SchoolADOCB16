using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolADOCB16.Views.Print
{
    interface IPrint<T>
    {
        void Print(T t);

        void PrintList(List<T> ts);

    }
}
