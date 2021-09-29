/*using System;
using System.Net.Http;

namespace CSharp_DayFour_Projects
{
    class PriceExcpetion: Exception
    {
        public PriceExcpetion(string message): base(message) { }
        public PriceExcpetion(): base("Invalid Price") { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                float sellingPrice, costPrice;
                Console.Write("Enter Selling Price : ");
                sellingPrice = float.Parse(Console.ReadLine());
                Console.Write("Enter Cost Price : ");
                costPrice = float.Parse(Console.ReadLine());
                if (sellingPrice <= 0)
                {
                    //throw new PriceExcpetion("Price Cannot be Zero or Less.");
                    throw new PriceExcpetion();
                }
                if (costPrice <= 0)
                {
                    //throw new PriceExcpetion("Price Cannot be Zero or Less.");
                    throw new PriceExcpetion();
                }
                else
                {
                    if (sellingPrice > costPrice)
                    {
                        Console.WriteLine("Profit Occurred.");
                    }
                    else if (costPrice > sellingPrice)
                    {
                        Console.WriteLine("Loss Occurred.");
                    }
                    else
                    {
                        Console.WriteLine("No Profit No Loss");
                    }
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("FormatException : " + ex.Message);
            }
            catch (PriceExcpetion ex)
            {
                Console.WriteLine("PriceException : " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception : " + ex.Message);
            }
            
            
            Console.ReadKey();
        }
    }
}
*/