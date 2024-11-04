using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace StreamReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation1 = "./" + args[0];
            string fileLocation2 = "./" + args[1];
            string line = "";
            int counter = 1;

            // Read from file1, place it into new file
            using (StreamWriter sw = new StreamWriter("CombinedFile.txt"))
            {
                using (StreamReader sr = new StreamReader(fileLocation1))
                {
                    while ((line = sr.ReadLine()) != null )
                    {
                        sw.WriteLine(counter + " " + line);
                        counter++;
                    }
                }

                using (StreamReader sr = new StreamReader(fileLocation2))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        sw.WriteLine(counter + " " + line);
                        counter++;
                    }
                }
            }
        }
    }
}
