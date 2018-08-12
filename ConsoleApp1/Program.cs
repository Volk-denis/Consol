using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstClass f = new FirstClass("Den", "Batia");
            Console.WriteLine(f.Name);
            f.Name = "Vitia";
            Console.WriteLine(f.Name);
                
            
            Console.ReadKey();

        }
    
       
    }
}

