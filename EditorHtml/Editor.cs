using System;
using System.Text;

namespace EditorHtml
{
    public static class Editor
    {
        
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor= ConsoleColor.Blue;
            Console.ForegroundColor= ConsoleColor.White;
            Console.Clear();
            Console.SetCursorPosition(8,0);
            Console.WriteLine("MODO EDITOR"); 
            Console.WriteLine(" ------------------");
            Start();
        }
        
        public static void Start()
        {
            var file = new StringBuilder();
            Console.WriteLine("");
            do {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while(Console.ReadKey().Key != ConsoleKey.Escape);
            
            Console.WriteLine("f");
            Console.WriteLine(" Deseja salvar o arquivo? Sim-S ou Não-N? ");

            char resp = char.Parse(Console.ReadLine());
            if(resp== 's')
            {  
                Console.WriteLine("Aquivo salvo com sucesso");
                Thread.Sleep(2500);
                Viewer.Show(file.ToString());
            }
            if(resp== 'n')
            Menu.Show();
        }
        
    }
}