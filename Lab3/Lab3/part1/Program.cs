using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace part1
{

 class Layer
 {
    public int index;
    public FileSystemInfo[] content;
    public Layer(FileSystemInfo[] content)
    {
        index = 0;
        this.content = content;
    }
    public void Color(bool mode)
    {
        if (mode == true)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            for (int i = 0; i < content.Length; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                if (content[i].GetType() == typeof(DirectoryInfo))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine(content[i].Name);
            }
        }
        else
        {
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Users\LENOVO\Desktop\1half");
            Stack<Layer> history = new Stack<Layer>();
            history.Push(new Layer(directoryInfo.GetFileSystemInfos()));
            bool escape = false;
            bool mode = true;
            while (!escape)
            {
                history.Peek().Color(mode);
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.Backspace:
                        mode = true;
                        history.Pop();
                        break;
                    case ConsoleKey.UpArrow:
                        if (history.Peek().index - 1 < 0)
                        {
                            history.Peek().index = history.Peek().content.Length - 1;
                        }
                        else
                            history.Peek().index--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (history.Peek().index + 1 >= history.Peek().content.Length)
                        {
                            history.Peek().index = 0;
                        }
                        else
                            history.Peek().index++;
                        break;
                    case ConsoleKey.Escape:
                        escape = true;
                        break;
                }
            }
        }
    }
}
}