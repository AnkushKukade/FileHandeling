using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileHandeling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WriteReadFile wf = new WriteReadFile();
             wf.WriteFile();
            //  wf.ReadFile();
            Console.Read();



        }
    }
}
