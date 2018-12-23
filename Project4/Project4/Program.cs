using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    /// <summary>
    /// Contains entry point for application
    /// </summary>
    class Program
    {    
        /// <summary>
          /// Defines the entry point for application
          /// </summary>
          /// <param name="args">A list of command line arguments</param>

        static void Main(string[] args)
        {
            Tasks t = new Tasks();
            t.ExecuteTasks();
            Console.Read();
        }
    }
}
