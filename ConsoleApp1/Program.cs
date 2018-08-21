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
        
        static CancellationTokenSource cts = new CancellationTokenSource();
        public static void Main(){
            

            var t = Task.Run(() => Add(cts.Token), cts.Token);

            Thread.Sleep(1000);
            cts.Cancel();
            Console.WriteLine(t.IsCanceled);
            Console.WriteLine(t.IsFaulted);
            Console.WriteLine(cts.Token.IsCancellationRequested);
            
            
            
            //Console.WriteLine(t.Result);

            Console.ReadKey();
        }

        public static void Add(CancellationToken t)
        {
            int a = 0;
            try
            {
                 while (!t.IsCancellationRequested)
                    {
                                
                                     Console.WriteLine(a++);
                                     Thread.Sleep(1000);
                                     t.ThrowIfCancellationRequested();
                              
                    }
                t.ThrowIfCancellationRequested();
            }
            catch(OperationCanceledException e)
            {
                Console.WriteLine("поток завершен!!!");
            }
            finally
            {
                cts.Dispose();
            }
            
           
        }
       
    }
      
}

