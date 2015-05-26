using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            string patch = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            patch = patch.Substring(0, patch.Length - 22);
            Process.Start(patch + @"\PK_Projekt\Rejestracja.Host\bin\Debug\Rejestracja.Host.exe");
            Thread.Sleep(1000);
            Process.Start(patch + @"\PK_Projekt\ObsługaKlienta.Host\bin\Debug\ObsługaKlienta.Host.exe");
            Thread.Sleep(1000);
            Process.Start(patch + @"\PK_Projekt\NowaUsługa.Host\bin\Debug\NowaUsługa.Host.exe");
            Thread.Sleep(1000);
            Process.Start(patch + @"\PK_Projekt\HistoriaTransakcji.Host\bin\Debug\HistoriaTransakcji.Host.exe");
            Thread.Sleep(1000);
            Process.Start(patch + @"\PK_Projekt\Statystyki.Host\bin\Debug\Statystyki.Host.exe");
            Thread.Sleep(1000);
            Process.Start(patch + @"\PK_Projekt\WysyłanieMaili.Host\bin\Debug\WysyłanieMaili.Host.exe");
            Thread.Sleep(1000);
            Process.Start(patch + @"\PK_Projekt\Wyświetl.Host\bin\Debug\Wyświetl.Host.exe");
            Thread.Sleep(2000);
            Process.Start(patch + @"\PK_Projekt\BazaDanych.Host\bin\Debug\BazaDanych.Host.exe");
            Thread.Sleep(3000);
            Process.Start(patch + @"\PK_Projekt\PK_Projekt\bin\Debug\PK_Projekt.exe");
        }
    }
}
