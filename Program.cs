using System;
using System.Text.RegularExpressions;
using System.Reflection;

namespace PizzaPalatsetG1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //  Auto invoke;
                //  Eftersom den enda aktören i programmet är Terminal-klassen
                //  så kan vi förutsätta att detta är det enda vi kallar på i main
                //
                //  argument att sätta i shortcuts till /bin/.exe filen
                //      order    
                //      front
                //      process  
                //      master
                //
                string arg = args[0];
                string method_name = "Run";
                string namespace_name = "PizzaPalatsetG1";

                arg += "Terminal";  // Namnet på klassen
                arg = arg.Substring(0, 1).ToUpper() + arg.Substring(1);  // Första bokstaven till stor ex "order" => "Order"

                Type type = Type.GetType(String.Format("{0}.{1}", namespace_name, arg)); // Hämtar classen
                MethodInfo method = type.GetMethod(method_name);  // Hämtar metoden "Run"
                object instance = Activator.CreateInstance(type); // Skapar instancen, => ex. new OrderTerminal()

                method.Invoke(instance, new object[0]); // Invokar metoden $terminal->Run()
            }
            catch (IndexOutOfRangeException)
            {
                Console.Write("Rätt .exe filer ej tillagda. Saknar startargument");
            }
            catch (System.Exception)
            {
                Console.Error.Write("Error occured ¯\\_(ツ)_/¯\n");
                throw;
            }
        }
    }
}
