using System;
using System.Text.RegularExpressions;

namespace EditorHtml
{
    public static class Viewer
    {
        public static void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor= ConsoleColor.Blue;
            Console.ForegroundColor= ConsoleColor.White;
            Console.Clear();
            Console.SetCursorPosition(8,0);
            Console.WriteLine("MODO VIZUALIZAÇÃO"); 
            Console.WriteLine(" ------------------");
            Replace(text);
        }
        public static void Replace(string text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(' ');

            for(var i= 0; i < words.Length; i++)
            {
                if(strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor= ConsoleColor.Yellow;
                    Console.Write(
                        words[i].Substring(
                            words[i].IndexOf('>') + 1,
                            ((words[i].LastIndexOf('<') -1) - words[i].IndexOf('>'))

                        )
                    );
                    Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(words[i]);
                    Console.Write("");
                }
            }
        }
    }
}