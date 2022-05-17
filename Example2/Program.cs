using System;

namespace Example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter fullName to register:");
                string fullName = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Error occurred: {0}");
            }
            finally
            {
                Console.Write("Enter fullName, name and surname:");
            }
            }
           
        }
    }

