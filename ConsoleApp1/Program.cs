using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.Globalization;
using System.Reflection;
using System.Linq;

namespace ConsoleApp1{

    class Program
    {
        public static int a = 0;
        public static object locer = new object();

        public static void Main(string[] arg) {
            
            for(int q = 10; q > 0; q--)
            {
                Thread t = new Thread(new ThreadStart(Add));
                t.Start();
                              
            }
            Console.ReadKey();


        }
        public static void Add()
        {
            lock (locer)
            while(a < 200)
            {
                
                a++;
                Console.WriteLine(a);
                Thread.Sleep(10);
            }
        }

        

        

        

        

        
    }
    
            
            
        
       
}

