using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Eda : IEnumerable<int>
    {
        private readonly int count; 
        public Eda(int count)
        {
            this.count = count;
        }
        public IEnumerator<int> GetEnumerator()
        {
            int a = 0;
            for(int q = 0; a < count; q++)
            {
                if (a == 0)
                {
                    
                    yield return a;
                }
                a +=200;
                yield return a;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


}
