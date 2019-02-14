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
                DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Users\LENOVO\Desktop\folder");
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
                        case ConsoleKey.Enter:
                            int x = history.Peek().index;
                            FileSystemInfo fileSystemInfo = history.Peek().content[x];
                            if (fileSystemInfo.GetType() == typeof(DirectoryInfo) )
                            {
                                FileSystemInfo[] content = (fileSystemInfo as DirectoryInfo).GetFileSystemInfos();
                                history.Push(new Layer(content));
                            }
                            else
                            {
                                mode = false;
                                FileStream fs = new FileStream(fileSystemInfo.FullName, FileMode.Open, FileAccess.Read);
                                StreamReader sr = new StreamReader(fs);
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.Clear();
                                Console.WriteLine(sr.ReadToEnd());
                                fs.Close();
                                sr.Close();
                            }
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
                        case ConsoleKey.Delete:
                            int x2 = history.Peek().index;
                            FileSystemInfo fileSystemInfo2 = history.Peek().content[x2] ;
                                history.Peek().index--;
                            if( fileSystemInfo2.GetType() == typeof(DirectoryInfo))
                            {
                                DirectoryInfo dirInfo = fileSystemInfo2 as DirectoryInfo;
                                Directory.Delete(fileSystemInfo2.FullName);
                                history.Peek().content = dirInfo.Parent.GetFileSystemInfos();
                            }
                            else
                            {
                                FileInfo fileInfo = fileSystemInfo2 as FileInfo;
                                File.Delete(fileSystemInfo2.FullName);
                                history.Peek().content = fileInfo.Directory.GetFileSystemInfos();
                            }
                            break;
                        case ConsoleKey.F2:
                            
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Clear();
                            string name = Console.ReadLine();
                            int x3 = history.Peek().index;
                            FileSystemInfo fileSystemInfo3 = history.Peek().content[x3];
                            if (fileSystemInfo3.GetType() == typeof(DirectoryInfo))
                            {
                                DirectoryInfo dirInfo = fileSystemInfo3 as DirectoryInfo;
                                Directory.Move(fileSystemInfo3.FullName, dirInfo.Parent + "/" + name);
                                history.Peek().content = dirInfo.Parent.GetFileSystemInfos();
                            }
                            else
                            {
                                FileInfo fileInfo = fileSystemInfo3 as FileInfo;
                                File.Move(fileSystemInfo3.FullName, fileInfo.Directory + "/" + name);
                                history.Peek().content = fileInfo.Directory.GetFileSystemInfos();
                            }
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

