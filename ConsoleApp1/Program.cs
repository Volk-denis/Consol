using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.Globalization;
using System.Reflection;

using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Numerics;

namespace ConsoleApp1{

    enum Figures { Romb, Rect, Triangle, Circle }
    struct Fdata
    {
        public int x0, y0;
        public int color;
        public Figures type;
    }


    class Program
    {

       
        
        public static void Main()
        {
            Fdata fdata = new Fdata() { x0 = 4, y0 = 3, color = 1234, type = Figures.Romb };
            Console.WriteLine(Area(fdata)?? 0);
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

            //MyStruct _struct = new MyStruct(1,2);
            //Console.WriteLine(_struct.A);
            //checked
            //{
            
           
                //Console.WriteLine( Factorial(6));
            //}
            

            Console.ReadKey();

           
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
        public static void A(int a, params int[] f)
        {
            Console.WriteLine(f.GetHashCode());
        }
        public static long Factorial(long s)
        {
            return s < 1 ? 1 : s * Factorial(--s);
        }
        public static double? Area(Fdata fd)
        {
            double res;
            switch (fd.type)
            {
                case Figures.Romb :
                    res = fd.x0 * fd.y0;
                    return res;
                case Figures.Circle:
                    res = fd.x0 - fd.y0;
                    return res;
                default:
                    return null;


            }
        }
        
       
    }

   
      
}

