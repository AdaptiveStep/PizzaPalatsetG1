using System;

namespace PizzaPalatsetG1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string arg = args[0];
            }
            catch(IndexOutOfRangeException){
                Console.Write("Rätt .exe filer ej tillagda. Saknar startargument");
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
