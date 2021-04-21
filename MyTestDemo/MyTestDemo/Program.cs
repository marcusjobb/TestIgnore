namespace MyTestDemo
{
    using System;
    using System.Diagnostics;

    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                var x = 10;
                var y = 2;
                string name = null;
                Console.WriteLine(x / y);
                
                Console.WriteLine(name.Length);

            }
            catch (DivideByZeroException ex)
            {
                Debug.WriteLine($"{DateTime.Now} : Försökte dela med 0 :-( --> {ex.Message}");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"{DateTime.Now} : {ex.Message}");
            }

        }
    }
}
