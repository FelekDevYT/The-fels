using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace Language
{
    public class Program
    { 
        public static void Main(string[] args)
        {
            Console.Write("enter path you file(for default program.fels)>");
            String file = Console.ReadLine();
           if(file == "")
            {
                Commander.MAIN("program.fels");
            }
            else
            {
                Commander.MAIN(file);
            }
        }
    }
}
