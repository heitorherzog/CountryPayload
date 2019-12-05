using System;
using System.Globalization;

namespace tech_test_ps
{
    public class ConsoleWrapper:IConsoleWrapper
    {
        
        public ConsoleWrapper()
        { 
        }
        public void Write(string message)
        {
            Console.Write(message);
        }
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
        public string ReadLine()
        {
            return Console.ReadLine();
        }
        public void Clear()
        {
            Console.Clear();
        }
        public void ReadKey()
        {
            Console.ReadKey();
        }
    }
}
    


