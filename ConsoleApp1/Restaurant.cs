using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
           
    class Restaurant
    {

        public void Read(Object sender, Eda e){
            Console.WriteLine($"обект {sender.GetType()}, патаметры а = {e.a},  b = {e.b}");
        }
  
    }
}
