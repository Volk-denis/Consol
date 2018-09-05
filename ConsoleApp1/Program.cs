using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.Globalization;
using System.Reflection;

using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace ConsoleApp1{
    class Program
    {

       
        
        public static void Main()
        {
            //поток доходит до асинк метода. Далее создается фоновой поток, который начинает работать
            //Основной далее выполняет действия до ключевого слова авэйт и выходит из метода ("ждет выполнеие таски"(не совсем так)). 
            //Как только фоновой поток закончит свою работу, основному потоку вернется управление в методе в котором создалась таска и
            //он завершит этот метод (все что после авэйт). Это касается и исключений.



            //var meenu = new Menu();
            //meenu.Add();

            //Thread.Sleep(2000);

            //meenu.cts.Cancel();
            //Console.WriteLine("Продолжаем работу");
            //new Restaurant().Add();
            //Console.ReadLine();

            //Restaurant restaurant = new Restaurant();
            //restaurant._a = 12;
            //Console.WriteLine(restaurant._a);
            //Chenge(ref restaurant);
            //Console.WriteLine(restaurant._a);

            //restaurant.GetType();
            //var d  = typeof(Restaurant);
            //var y = Type.GetType("ConsoleApp1.Restaurant");
            //foreach (var t in y.GetMethods())
            //    Console.WriteLine(t.ToString());
            //MethodInfo[] f = d.GetMethods();
            //Console.WriteLine("Продолжаем работу");
            //Thread.Sleep(2000);
            //Console.WriteLine("Далее продолжаем");
            //menu.Cancel();

            MyStruct _struct = new MyStruct(1,2);
            Console.WriteLine(_struct.A);

            Console.ReadLine();

           
        }

        public static void Add(CancellationToken ct)
        {
            for(int ca = 0; ca < 123; ca++)
            {
                ct.ThrowIfCancellationRequested();
                Console.WriteLine(ca);
                Thread.Sleep(100);
            }
           
        }
        public static void Chenge(ref Restaurant r)
        {
            Restaurant restaurant = new Restaurant() { _a = 40 };
            r = restaurant;
            
        }
        
       
    }

   
      
}

