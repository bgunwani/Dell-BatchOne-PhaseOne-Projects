/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DayFour_Projects
{
    class TempRecord
    {
        private float[] temps = new float[5] { 56.2F, 56.7F, 56.5F, 56.9F, 58.8F };
        public int Length
        {
            get { return temps.Length; }
        }
        public float this[int index]
        {
            get
            {
                if(index < Length)
                {
                    return temps[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Index Should be in range of 0-4.");
                }
            }
            set
            {
                if(index < Length)
                {
                    temps[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index Should be in range of 0-4.");
                }
            }
            
        }
    }
    class IndexerExample
    {
        static void Main(string[] args)
        {
            TempRecord tempRecord = new TempRecord();
            try
            {
                // Set Accessor:
                tempRecord[0] = 89.0F;
                tempRecord[1] = 90.6F;
                // tempRecord[7] = 56.7F;
                for (int i = 0; i < tempRecord.Length; i++)
                {
                    Console.WriteLine("\nElement #{0} : {1}", i, tempRecord[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
*/