using System;
using Gtk;

namespace ConnectFourGUI
{
    class WindowControls
    {
        /*
        public static bool BuildWindow(Window window)
        {
            window.Build();
            return false;
        }
        */
        
        public static bool ShowWindow(Window window)
        {
            window.ShowAll();
            return true;
        }
        public static bool HideWindow(Window window)
        {
            window.HideAll();
            return false;
        }
    }
    class MainClass
    {
        public static void Main()
        {
            Application.Init();
            MainWindow win = new MainWindow();
            win.Show();
            Application.Run();
        }
    }
}
