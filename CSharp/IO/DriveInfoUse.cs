using System;
using System.IO;

namespace FileApp
{
    class Program
    {
        static void Main()
        {
            var drives = DriveInfo.GetDrives();
            const double bytesInMegabyte = 1024 * 1024;
            const double bytesInGigabyte = 1024 * bytesInMegabyte;
            foreach (var drive in drives)
            {
                Console.WriteLine("Название: " + drive.Name);
                Console.WriteLine("Тип: " + drive.DriveType);
                if (drive.IsReady) 
                {
                    Console.WriteLine("Файловая система: " + drive.DriveFormat);
                    Console.WriteLine("Объем: {0:0.00} ГБайт", drive.TotalSize / bytesInGigabyte);
                    Console.WriteLine("Свободное место: {0:0.00} ГБайт", drive.TotalFreeSpace / bytesInGigabyte);
                    Console.WriteLine("Метка: " + drive.VolumeLabel ?? "отсутствует");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Нажмите Enter чтобы продолжить...");
            Console.ReadLine();
        }
    }
}