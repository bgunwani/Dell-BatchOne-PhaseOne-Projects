/*using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DayFour_Projects
{
    class StreamWriterExample
    {
        static void Main(string[] args)
        {
            //FileStream fileStream = new FileStream("D:\\data\\data.txt", FileMode.Append, FileAccess.Write);
            //StreamWriter streamWriter = new StreamWriter(fileStream);
            //streamWriter.WriteLine("Hello Everyone");
            //streamWriter.WriteLine("Lets Learn File Handling.");
            //Console.WriteLine("Content Written to the file successfully.");
            //streamWriter.Close();
            //fileStream.Close();

            using(FileStream fileStream = new FileStream("D:\\data\\data.txt", FileMode.Append, FileAccess.Write))
            {
                using(StreamWriter streamWriter = new StreamWriter(fileStream))
                {
                    streamWriter.WriteLine("Hello Everyone");
                    streamWriter.WriteLine("Lets Learn File Handling.");
                    Console.WriteLine("Content Written to the file successfully.");
                }
            }
        }
    }
}
*/