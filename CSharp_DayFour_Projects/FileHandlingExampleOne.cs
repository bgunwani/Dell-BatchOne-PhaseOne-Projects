/*using System;
using System.IO;
using System.Text;

namespace CSharp_DayFour_Projects
{
    class FileHandlingExampleOne
    {
        static void Main(string[] args)
        {
            // Demonstration 1:
            //FileStream fileStream = new FileStream("D:\\data\\info.txt", FileMode.Append, FileAccess.Write);
            //Console.WriteLine("File Created Successfully.");
            //byte[] bdata = Encoding.Default.GetBytes("Hello Everyone");
            //fileStream.Write(bdata, 0, bdata.Length);
            //Console.WriteLine("Content Written to the File.");
            //fileStream.Close();

            // Demonstration 2:
            string data;
            FileStream fileStream = new FileStream("D:\\data\\info.txt", FileMode.Open, FileAccess.Read);
            //using(StreamReader streamReader = new StreamReader(fileStream))
            //{
            //    data = streamReader.ReadToEnd();
            //}
            StreamReader streamReader = new StreamReader(fileStream);
            data = streamReader.ReadToEnd();
            Console.WriteLine(data);
            streamReader.Close();
            fileStream.Close();

        }
    }
}
*/