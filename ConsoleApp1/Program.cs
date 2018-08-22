using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.Globalization;
using System.Reflection;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1{
    class Program
    {
        public static void Main()
        {
            //    Суть такая: стартует маин, доходит до создания еще одного потока. Создает его и стартует. 
            //    Продолжает работу и доходит до Threa.sleep. Ждет 2 секунды и вызывает сброс маркера.
            //    Генерируется исключение OperationCanceledException во втором потоке и поток останавливается.

            //    Если в методе в котором создавался второй поток отсутствуют await/async,
            //    первый продолжает работать, маркеры isCanceled не срабатывают из-за ошибки во втором потоке и маин завершает работу.
            //    Если мы возобновим работу второго потока после исключения, он тоже завершится, но таск будет в isCanceled = false.

            //    Для этого метод в которов создаем таск вписываем async, а таск await. Таким образом, маин после проброса исключения
            //    во втором потоке приостанавливает свою работу, ждет пока исключение обработается, т.е во время проброса исключения вся программа "стоит",
            //    а после обработки возобновляет своюработую Т.о коректно выставляюся маркеры, а isCanceled = true.
            //    Второй поток не выходит из своего метода до завершения работы или в случаи прерывания.

            //new Restaurant().Add();
            var meenu = new Menu();
            meenu.Add();
            Console.WriteLine("Продолжаем работу");
            Thread.Sleep(2000);
            meenu.cts.Cancel();
            
            Console.ReadLine();
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

