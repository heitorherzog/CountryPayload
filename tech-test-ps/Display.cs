﻿using System;

namespace tech_test_ps
{
    public class Display: IDisplay
    {
        private IConsoleWrapper Console { get;}
        public Display(IConsoleWrapper console)
        {
            Console = console;
        }
        public string ShowLinePrompt(string text)
        {
            Console.WriteLine(text);
            return Readline();
        }

        public void ShowLinePromptAnyKey(string text)
        {
            Console.WriteLine(text);
            ReadKey();
        }
        public void ShowLine(string text)
        {
            Console.WriteLine(text);
        }

        public string Readline()
        {
           return  Console.ReadLine();
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
    


