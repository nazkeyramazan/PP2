using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FarManager
{
    class Layer
    {
        public int SelectedItem;
        public FileSystemInfo[] items;

        public Layer(FileSystemInfo[] items)
        {
            SelectedItem = 0;
            this.items = items;
        }
        public void Color(bool mode)
        {
            if (mode == true)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                for (int i = 0; i < items.Length; ++i)
                {
                    if (i == SelectedItem)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    if (items[i].GetType() == typeof(DirectoryInfo))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine(items[i].Name);
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
            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Users\LENOVO\Desktop\1half");//указывает путь к папке
            Stack<Layer> history = new Stack<Layer>();
                history.Push(new Layer(dirInfo.GetFileSystemInfos()));

                bool quit = false;
                bool mode = true; //1 - folder 0 - file

            while (!quit)
            {
                    history.Peek().Color(mode);
                ConsoleKeyInfo pressedKey = Console.ReadKey();

                    switch (pressedKey.Key)
                    {
                        case ConsoleKey.UpArrow:
                           if ( history.Peek().SelectedItem - 1 < 0)
                            {
                                history.Peek().SelectedItem = history.Peek().items.Length-1;
                            }
                            else 
                            {
                                history.Peek().SelectedItem--;
                            }
                            break;
                        case ConsoleKey.DownArrow:
                            if (history.Peek().SelectedItem + 1 >= history.Peek().items.Length )
                            {
                                history.Peek().SelectedItem = 0;
                            }
                            else
                            {
                                history.Peek().SelectedItem++;
                            }
                            break;
                        case ConsoleKey.Enter:
                            int x = history.Peek().SelectedItem;
                            FileSystemInfo SelectedFSI = history.Peek().items[x];
                            if(SelectedFSI.GetType() == typeof(DirectoryInfo))
                            {
                                FileSystemInfo[] items = (SelectedFSI as DirectoryInfo).GetFileSystemInfos();
                                history.Push(new Layer(items));
                            }
                            else
                            {
                                mode = false;
                                FileStream fs = new FileStream(SelectedFSI.FullName, FileMode.Open, FileAccess.Read);
                                StreamReader sr = new StreamReader(fs);

                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Clear();
                                Console.WriteLine(sr.ReadToEnd());
                                sr.Close();
                                fs.Close();
                            }
                            break;
                        case ConsoleKey.Backspace:
                            mode = true;
                            history.Pop();
                            /*
                              if(mode == true)
                            history.Pop();
                            else
                            {
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.White;
                                mode = false;
                            }
                            */
                            break;
                        case ConsoleKey.Escape:
                            quit = true;
                            break;

                    }      
               }
            }
        }
    }
}
