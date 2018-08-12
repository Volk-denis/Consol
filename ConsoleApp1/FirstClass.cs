using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    

    class FirstClass {

        private string name;
        private string name2;

        public FirstClass()
        {

        }

        public FirstClass(string name, string name2)
        {
            this.name = name;
            this.name2 = name2;

        }

        public string Name
        {
            get {
                return name;
            }
            set {
                this.name = value;
                
            }
        }
        public string Name2
        {
            get
            {
                return this.name2;
            }
            set
            {
                this.name2 = value;

            }
        }


    }
}
