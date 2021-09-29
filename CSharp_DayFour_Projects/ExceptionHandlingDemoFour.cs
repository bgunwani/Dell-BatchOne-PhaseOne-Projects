/*using System;
using System.Net.Http;

namespace CSharp_DayFour_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = null;
            try
            {
                client = new HttpClient();
                var result = client.GetStringAsync("https://www.google.com/").Result;
                Console.WriteLine(result.ToString());
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Catch Block 1 : " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Catch Block 2 : " + ex.Message);
            }
            finally
            {
                client?.Dispose();
            }

            Console.ReadKey();
        }
    }
}
*/