using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
           
    class Restaurant
    {

        public void Add()
        {
            Task.Factory.StartNew(() =>
            {
                for (int a = 0; a < 143; a++)
                {
                    Console.WriteLine(".");
                    Thread.Sleep(100);

                }
            });
        }
  
    }
}
