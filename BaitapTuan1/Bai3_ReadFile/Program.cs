using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace Bai3_ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList studentList = new ArrayList();
            try
            {
                StreamReader sr = new StreamReader("students.txt");
                string line;
                int count = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    object studentInfo = line;
                    studentList.Add(studentInfo);
                    count++;
                    Console.WriteLine($"{count} objects has been added into the list.");
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
