using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandeling
{
    public class WriteReadFile
    {
        public void WriteFile()
        {
            try
            {
                 // provide ---> \\ or @ , to path to remove errors in path.
                FileStream fs = new FileStream(@"D:\IKS\dotnet\file.txt", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);

                Console.WriteLine("Students details are as follow : ");
                Console.WriteLine("Enter Name : ");
                String Name = Console.ReadLine();
                sw.WriteLine(Name);

                Console.WriteLine("Enter ID : ");
                int id = Convert.ToInt32(Console.ReadLine());
                sw.WriteLine(id);

                Console.WriteLine("Enter College Name : ");
                string clgname = Console.ReadLine();
                sw.WriteLine(clgname);

                sw.Close();
                fs.Close();
                Console.WriteLine("File Created...");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void ReadFile()
        {
            FileStream fs = new FileStream(@"D:\IKS\dotnet\file.txt", FileMode.Open, FileAccess.Read);
           // StreamWriter sw = new StreamWriter(fs);
            StreamReader sr = new StreamReader(fs);

            while(sr.Peek()> 0)
            {
                Console.WriteLine(sr.ReadLine());
            }

        }
    }
}
