using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    class Menu 
    {
        
        CancellationTokenSource cts = new CancellationTokenSource();
        public async void Add()
        {
            
            Task task = new Task(() => Qw());
            try
            {
                task.Start();
                await task;
                  
            }
            catch (OperationCanceledException)
            {
                if (task.IsCanceled) 
                    MessageBox.Show("Поток завершен");
            }
            catch (Exception)
            {
                Console.WriteLine("Обработка ошибки");
            }
            Console.WriteLine(Thread.CurrentThread.Name);
            Console.WriteLine(task.IsFaulted);
            Console.WriteLine(task.IsCanceled);
            Console.WriteLine(task.IsCompleted);

        }

        public void Qw()
        {
            
        }

        public void Cancel()
        {
            cts.Cancel();
        }
     
    }
}
