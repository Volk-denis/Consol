using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.Globalization;
using System.Reflection;
using System.Linq;
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

            //
            //var meenu = new Menu();
            //meenu.Add();

            //Thread.Sleep(2000);

            //meenu.cts.Cancel();
            //Console.WriteLine("Продолжаем работу");
            //new Restaurant().Add();
            //Console.ReadLine();
            Task<string> f = new WebClient().DownloadStringTaskAsync("http://tut.by/");
            string ff = f.Result;

            File.WriteAllText(@"d:/123.txt", ff);
            Console.ReadKey();
        }

        public static void Add(CancellationToken ct)
        {
            for(int ca = 0; ca < 123; ca++)
            {

                if(ct.IsCancellationRequested)
                    ct.ThrowIfCancellationRequested();
                
                Thread.Sleep(1000);
                //if (ca == 2) throw new Exception();
                Console.WriteLine(ca);
            }
            

            
           
        }
       
    }
      
}

