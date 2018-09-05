using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

        //Наследуется от ValueType размещается в стеке. Имеет конструктор. По умолчаниюпеременные приватные. Конструктор можно перегружать.
        //По умолчанию поля инициализуются нулями.
    struct MyStruct
    {
        public int A;
        public int C;

        public MyStruct(int a, int c)
        {
            A = a;
            C = c;
        }
    }
}
