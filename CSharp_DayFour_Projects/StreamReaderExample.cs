/*using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DayFour_Projects
{
    class StreamReaderExample
    {
        static void Main(string[] args)
        {
            using (FileStream fileStream = new FileStream("D:\\data\\data.txt", FileMode.Open, FileAccess.Read))
            {
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    var data = streamReader.ReadToEnd();
                    Console.WriteLine(data);
                }
            }
        }
    }
}
*/