using BaseConsoleCoreTemplate.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


// ReSharper disable once CheckNamespace
namespace BaseConsoleCoreTemplate
{
    /// <summary>
    /// Make this console window full-screen, set title
    /// </summary>
    public partial class Program
    {
        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();
        private static readonly IntPtr ThisConsole = GetConsoleWindow();
        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int cmdShow);
        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = GetSettings.ApplicationSettings().Title;
            if (GetSettings.ApplicationSettings().FullScreen)
            {
                ShowWindow(ThisConsole, 3);
            }

        }
    }
}
