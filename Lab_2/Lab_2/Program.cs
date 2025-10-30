using System.IO;

namespace Lab_2
{

    class Programm
    {
        static void Main()
        {
            while (true)
            {
                int choose = -1;
                try
                {
                    Console.WriteLine("\nДоступные команды:");
                    Console.WriteLine("0. Выйти из программы\n" +
                                      "1. Просотр содержимого директории\n" +
                                      "2. Удалить файл/папку\n" +
                                      "3. Копировать файл/папку\n" +
                                      "4. Переимновать файл/папку\n" +
                                      "5. Переместить файл/папку\n" +
                                      "6. Поиск файла/папки\n");
                    Console.Write("Введи номер команды: ");
                    choose = int.Parse(Console.ReadLine());
                    Console.Write("\n");
                }
                catch
                {
                    Console.WriteLine("\nВводи только одно число из списка команд!");
                }

                if (choose == -1)
                {
                    continue;
                }

                if (choose == 0)
                {
                    break;
                }
                
                else if (choose == 1)
                {
                    Console.WriteLine("Введи абсолютный путь до папки");
                    string path = Console.ReadLine();
                    try
                    {
                        file_manager File_manager = new file_manager();
                        File_manager.Path(path);
                    }
                    catch
                    {
                        Console.WriteLine("Неверно введен путь до директории. Вводи абсолютный путь!");
                    }
                }
                
                else if(choose == 2)
                {
                    Console.WriteLine("Введи абсолютный путь до директории/файла");
                    string path = Console.ReadLine();
                    try
                    {
                        Command command = new Command();
                        command.delete(path);
                    }
                    catch
                    {
                        Console.WriteLine("Неверно введен путь до директории/папкм. Вводи абсолютный путь!");
                    }
                }

                else if(choose == 3)
                {
                    Console.WriteLine("Введи абсолютный путь до директории/файла, который нужно переместить: ");
                    string sourth_path = Console.ReadLine();
                    Console.WriteLine("Введи абсолютный путь до директории, куда нужно скопировать: ");
                    string goal_path = Console.ReadLine();
                    try
                    {
                        Command command = new Command();
                        command.copy(sourth_path, goal_path);
                    }
                    catch
                    {
                        Console.WriteLine("Неверно введен путь до директории/папкм. Вводи абсолютный путь!");
                    }
                }

                else if(choose == 4)
                {
                    Console.WriteLine("Введи абсолютный путь до директории/файла, который нужно переименовать: ");
                    string path = Console.ReadLine();
                    Console.WriteLine("Введи новое имя файла/папки: ");
                    string new_name = Console.ReadLine();
                    try
                    {
                        Command command = new Command();
                        command.rename(path, new_name);
                    }
                    catch
                    {
                        Console.WriteLine("Неверно введен путь до директории/папкм. Вводи абсолютный путь!");
                    }
                }

                else if(choose == 5)
                {
                    Console.WriteLine("Введи абсолютный путь до директории/файла, который нужно переместить: ");
                    string sourth_path = Console.ReadLine();
                    Console.WriteLine("Введи абсолютный путь до места перемещения вместе с названием файла и его форматом: ");
                    string goal_path = Console.ReadLine();
                    try
                    {
                        Command command = new Command();
                        command.replace(sourth_path, goal_path);
                    }
                    catch
                    {
                        Console.WriteLine("Неверно введен путь до директории, либо данный файл отстствует");
                    }
                }

                else if(choose == 6)
                {
                    Console.WriteLine("Введи абсолютный путь до директории, где нужно найти файл: ");
                    string dir_path = Console.ReadLine();
                    Console.WriteLine("Введи название искомого файла: ");
                    string file_name = Console.ReadLine();

                    try
                    {
                        Command command = new Command();
                        command.search(dir_path, file_name);
                    }
                    catch
                    {
                        Console.WriteLine("Неверно введен путь до директории/папкм, либо выбранный файл уже есть в выбранной директории");
                    }
                }
                else
                {
                    Console.WriteLine("\nВводи только одно число из списка команд!");
                }
            }
        }
    }
}



