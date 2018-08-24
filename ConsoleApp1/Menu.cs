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
        public CancellationTokenSource cts = new CancellationTokenSource();
        public async void Add()
        {
            Task task = null;
            var t = cts.Token;
            try
            {
                 task = Task.Run(() => Qw(t),t);
                 await task;
            }
            catch (OperationCanceledException)
            {
                if (task.IsCanceled) 
                    MessageBox.Show("Поток завершен");
            }

            Console.WriteLine(task.IsCanceled);
  
        }

        public void Qw(CancellationToken ct)
        {
            for(int a = 0; a < 234; a++)
            {
                Console.WriteLine(a);
                ct.ThrowIfCancellationRequested();
                //if (a == 4) throw new Exception();
                Thread.Sleep(100);
                
            }
        }
     
    }
}
