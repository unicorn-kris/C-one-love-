﻿using System;
using System.IO;

namespace Task_4
{

    class Program
    {
        enum Decide
        {
            Watch,
            Back
        };
        static int InputDecide()
        {
            int N;
            bool insert = int.TryParse(Console.ReadLine(), out N);
            if (!insert || N < 0 || N > 1)
            {
                Console.WriteLine("Enter the correct value");
                insert = int.TryParse(Console.ReadLine(), out N);
            }
            return N;
        }
        static int Input(int start, int end)
        {
            int N;
            bool insert = int.TryParse(Console.ReadLine(), out N);
            if (!insert || N < start || N > end)
            {
                Console.WriteLine("Enter the correct value");
                insert = int.TryParse(Console.ReadLine(), out N);
            }
            return N;
        }
        static DateTime InputDate()
        {
            bool date = false;
            int day;
            int month;
            int year;
            int hour;
            int minute;
            int second;
            DateTime inputDate = DateTime.Now;
            while (!date)
            {
                Console.WriteLine("Enter day");
                day = Input(1, 31);
                Console.WriteLine("Enter month");
                month = Input(1, 12);
                Console.WriteLine("Enter year");
                year = Input(1900, DateTime.Now.Year);
                Console.WriteLine("Enter hour");
                hour = Input(0, 23);
                Console.WriteLine("Enter minute");
                minute = Input(0, 60);
                Console.WriteLine("Enter second");
                second = Input(0, 60);
                inputDate = new DateTime(year, month, day, hour, minute, second);

                if (inputDate <= DateTime.Now)
                    date = true;
                else
                    Console.WriteLine("Enter the correct date and time");
            }
            return inputDate;
        }
        static void Main(string[] args)
        {

            string pathMain = @"C:/Monitoring";
            if (!Directory.Exists(pathMain))
            {
                Directory.CreateDirectory(pathMain);
            }

            string pathCopy = @"C:/Monitoring_Copy";
            if (!Directory.Exists(pathCopy))
            {
                Directory.CreateDirectory(pathCopy);
            }

            Console.WriteLine("Path of the catalog: C:/ Monitoring");

            using (FileStream fileStream = File.Open("LOG.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)) ;
            using (FileStream fileStream = File.Open("LOG_Copy.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)) ;

            Console.WriteLine("Choose a mode: 0 - Wach, 1 - Rollback");
            int mode = InputDecide();
            if (mode == (int)Decide.Watch)
            {
                MonitorDirectory(pathMain);

            }
            else if (mode == (int)Decide.Back && Directory.Exists(pathMain) && Directory.Exists(pathCopy))
            {
                BackDirectory();
            }

        }

        static string path = Path.Combine(Directory.GetCurrentDirectory(), "LOG.txt");
        static string pathCopy = "C:/Monitoring_Copy";

        static void MonitorDirectory(string path)
        {
            FileSystemWatcher fileSystemWatcher = new FileSystemWatcher();
            fileSystemWatcher.NotifyFilter = NotifyFilters.FileName
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.Security
                                 | NotifyFilters.Size;

            fileSystemWatcher.Path = path;
            fileSystemWatcher.Created += OnCreated;
            fileSystemWatcher.Renamed += OnRenamed;
            fileSystemWatcher.Deleted += OnDeleted;
            fileSystemWatcher.Changed += OnChanged;
            fileSystemWatcher.EnableRaisingEvents = true;

            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        }
        private static void OnChanged(object sender, FileSystemEventArgs e)
        {
            var lastAccess = File.GetLastAccessTime(e.FullPath);
            var lastWrite = File.GetLastWriteTime(e.FullPath);
            var createTime = File.GetCreationTime(e.FullPath);

            if (lastWrite != createTime && lastAccess != createTime && lastAccess != lastWrite)
            {
                {
                    using (StreamWriter log = new StreamWriter(path, true))
                    {
                        DateTime now = DateTime.Now;
                        string Copy = pathCopy + "/" + "__" + now.Day + "_" + now.Month + "_" + now.Year + "_" + now.Hour + "_" + now.Minute + "_" + now.Second + "-" + e.Name;

                        if (File.Exists(Copy))
                        {
                            FileStream fs = File.OpenRead(Copy);
                            fs.Close();
                            File.Delete(Copy);
                        }
                        else
                        {
                            log.WriteLine($"{now} Changed: {e.Name}");
                        }

                        File.Copy(e.FullPath, Copy);
                    }
                }
            }
            
        }

        public static string CopyOfFile(DateTime now, FileSystemEventArgs e)
        {
            string copy = pathCopy + "/" + "__" + now.Day + "_" + now.Month + "_" + now.Year + "_" + now.Hour + "_" + now.Minute + "_" + now.Second + "-" + e.Name;
            return copy;
        }

        private static void OnCreated(object sender, FileSystemEventArgs e)
        {
            using (StreamWriter log = new StreamWriter(path, true))
            {
                DateTime now = DateTime.Now;
                log.WriteLine($"{now} Created: {e.Name}");

                string copy = CopyOfFile(now, e);
                FileStream fs = File.Create(copy);
                fs.Close();
            }
        }

        private static void OnRenamed(object sender, RenamedEventArgs e)
        {
            using (StreamWriter log = new StreamWriter(path, true))
            {
                DateTime now = DateTime.Now;
                log.WriteLine($"{now} Renamed: {e.OldName} NewName: {e.Name}");

                string copy = CopyOfFile(now, e);
                File.Create(copy);
            }
        }

        private static void OnDeleted(object sender, FileSystemEventArgs e)

        {
            using (StreamWriter log = new StreamWriter(path, true))
            {
                DateTime now = DateTime.Now;
                log.WriteLine($"{now} Deleted: {e.Name}");
            }
        }


        static string pathLogCopy = Path.Combine(Directory.GetCurrentDirectory(), "LOG_Copy.txt");

        static void BackDirectory()
        {
            
            Console.WriteLine("Enter date for backup");
            DateTime dateBackUp = InputDate();

            bool changes = false;

            foreach (string folder in Directory.GetFiles("C:/Monitoring"))
            {
                File.Delete(folder);
            }

            using (StreamReader log = new StreamReader(path))
            {
                using (StreamWriter log_copy = new StreamWriter(pathLogCopy, false))
                {

                    
                    string read = log.ReadLine();
                    if (read != null)
                    {
                        string[] data = read.Split(new[] { ' ', ':', '.' }, StringSplitOptions.RemoveEmptyEntries);
                        DateTime newDateTime = new DateTime(int.Parse(data[2]), int.Parse(data[1]), int.Parse(data[0]), int.Parse(data[3]), int.Parse(data[4]), int.Parse(data[5]));
                        string action = "";

                        while (newDateTime <= dateBackUp )
                        {
                            if (data.Length > 1)
                            {
                                action = data[6];
                                if (action == "Created")
                                    Created(data);
                                else if (action == "Deleted")
                                    Deleted(data);
                                else if (action == "Renamed")
                                    Renamed(read);
                                else if (action == "Changed")
                                    Changed(read);
                                read = read.Remove(0, 19);
                                log_copy.WriteLine($"{DateTime.Now}{read}");
                            }

                            if (read != null && read != "")
                            {
                                if (data[0] == "DeleteAll")
                                    foreach (string folder in Directory.GetFiles("C:/Monitoring"))
                                    {
                                        File.Delete(folder);
                                    }
                            }

                            read = log.ReadLine();
                            data = read.Split(new[] { ' ', ':', '.' }, StringSplitOptions.RemoveEmptyEntries);

                            if (data.Length > 1)
                            {
                                newDateTime = new DateTime(int.Parse(data[2]), int.Parse(data[1]), int.Parse(data[0]), int.Parse(data[3]), int.Parse(data[4]), int.Parse(data[5]));
                            }

                        }
                        changes = true;
                    }
                    else
                        Console.WriteLine("There were no changes");
                }
            }

            if (changes)
            using (StreamWriter log = new StreamWriter(path, true))
            {
                using (StreamReader log_copy = new StreamReader(pathLogCopy))
                {
                    string read = log_copy.ReadToEnd();
                    log.WriteLine("DeleteAll");
                    log.WriteLine(read);
                }
            }

            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        }

        public static string RenameOrCreateForCopyPath(string[] data, string name)
        {
            string file = "C:/Monitoring_Copy/" + $"__{int.Parse(data[0])}_{int.Parse(data[1])}_{int.Parse(data[2])}_{int.Parse(data[3])}_{int.Parse(data[4])}_{int.Parse(data[5])}-" + name;
            return file;
        }

        public static string CopyString(string name)
        {
            DateTime now = DateTime.Now;
            string copy = pathCopy + "/" + "__" + now.Day + "_" + now.Month + "_" + now.Year + "_" + now.Hour + "_" + now.Minute + "_" + now.Second + "-" + name;
            return copy;
        }

        private static void Changed(string read)
        {
            string[] data = read.Split(new[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
            string name = "";

            for (int i = 5; i < data.Length; ++i)
            {
                 if (i != 5)
                    name += " " + data[i];
                else
                    name += data[i];
            }

            data = read.Split(new[] { ' ', ':', '.' }, StringSplitOptions.RemoveEmptyEntries);
            string old = "C:/Monitoring/" + name;
            string newFile = RenameOrCreateForCopyPath(data, name);
            
            File.Delete(old);
            File.Copy(newFile, old);

            string copy = CopyString(name);
        }

        private static void Created(string[] data)
        {
            string name = "";
            
            for (int i = 7; i < data.Length; ++i)
            {
                if (i == data.Length - 1)
                    name += '.' + data[i];
                else if (i != 7)
                    name += " " + data[i];
                else
                    name += data[i];
           }
            
            string create = RenameOrCreateForCopyPath(data, name);
            string newFile = "C:/Monitoring/" + name;
            File.Copy(create, newFile);

            string copy = CopyString(name);
            
            FileStream fs = File.Create(copy);
            fs.Close();
        }

        private static void Renamed(string read)
        {
            string[] data = read.Split(new[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
            string name = "";
            string newName = "";
            int j = 5;
            
            for (int i = 5; i < data.Length; ++i)
            {
                if (data[i] != "NewName")
                {
                    if (i == data.Length - 1)
                        name += '.' + data[i];
                    else if (i != 5)
                        name += " " + data[i];
                    else
                        name += data[i];
                }
                
                else
                {
                    j = i;
                    break;
                }
            }
            
            for (int i = j + 1; i < data.Length; ++i)
            {
                newName += data[i];
            }

            data = read.Split(new[] { ' ', ':', '.' }, StringSplitOptions.RemoveEmptyEntries);
            string Old = "C:/Monitoring/" + name;
            string newFile = RenameOrCreateForCopyPath(data, name);
            string newFileName = "C:/Monitoring/" + newName;
            
            File.Delete(Old);
            File.Copy(newFile, newFileName);

            string copy = CopyString(name);

            if (!File.Exists(copy))
            File.Create(copy);
        }

        private static void Deleted(string[] data)

        {
            string name = "";
            for (int i = 7; i < data.Length; ++i)
            {
                if (i == data.Length - 1)
                    name += '.' + data[i];
                else if (i != 7)
                    name += " " + data[i];
                else
                    name += data[i];
            }
            
            string delete = "C:/Monitoring/" + name;
            
            if (File.Exists(delete))
                File.Delete(delete);
        }
    }
}
