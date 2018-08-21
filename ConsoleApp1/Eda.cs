using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Eda : EventArgs
    {
        public int a {get;  set;}
        public String b {get;  set;}

        public Eda(int a, String b){
            this.a = a;
            this.b = b;
            
        }
        
    }


}
