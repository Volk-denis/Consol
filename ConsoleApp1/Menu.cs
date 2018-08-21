using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Menu 
    {
        public void Read(Object sender, Eda e)
        {
            Console.WriteLine($"обект {sender.GetType()}, патаметры а = {e.a},  b = {e.b}");
        }
     
    }
}
