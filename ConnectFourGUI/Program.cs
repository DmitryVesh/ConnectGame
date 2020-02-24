using System;
using Gtk;

namespace ConnectFourGUI
{
    public class MyWindows : Window
    {
        protected bool showing = false, deleted = false;

        public MyWindows() : base(Gtk.WindowType.Toplevel)
        {
            deleted = false;
            DeleteEvent += delegate { DeleteWindow(); };
        }
        public void ShowWindow()
        {
            ShowAll();
            showing = true;
        }
        public void HideWindow()
        {
            HideAll();
            showing = false;
        }
        public void DeleteWindow()
        {
            showing = false;
            deleted = true;
        }
        public bool IsDeleted()
        {
            return deleted;
        }
        public bool IsShowing()
        {
            return showing;
        }
    }

    class MainClass
    {
        public static void Main()
        {
            Application.Init();
            MainWindow win = new MainWindow();
            win.ShowWindow();
            Application.Run();
        }
    }
}
