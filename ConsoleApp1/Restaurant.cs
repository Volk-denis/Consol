using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
           
    class Restaurant
    {

        public void Add()
        {
            Task<string> f = new WebClient().DownloadStringTaskAsync("http://habrahabr.ru/");

        }
  
    }
}
