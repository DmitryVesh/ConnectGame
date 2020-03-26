using System;
using System.Collections.Generic;
using Gtk;

namespace ConnectFourGUI
{
    public class MyWindow : Window
    {
        protected bool showing = false, deleted = false;

        public MyWindow() : base(Gtk.WindowType.Toplevel)
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

            WindowClass.main.ShowWindow();
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
    public class MyComboBox : ComboBox
    {
        List<string> contents = new List<string>();
        public string previousActiveText { get; set; }
        public readonly string id;

        public MyComboBox(string[] elements, string id) : base(elements)
        {
            foreach (string element in elements) { contents.Add(element); }
            previousActiveText = "";
            this.id = id;
        }
        public void DeleteElement(string element)
        {
            RemoveText(contents.IndexOf(element));
            contents.Remove(element);
        }
        public void InsertElement(int position, string element)
        {
            InsertText(position, element);
            contents.Insert(position, element);
        }
        public void AppendElement(string element)
        {
            AppendText(element);
            contents.Add(element);
        }
    }

    public class MainClass
    {
        public static void Main()
        {
            Application.Init();
            WindowClass allWindows = new WindowClass();
            Application.Run();
        }
    }
    public class WindowClass
    {
        public static MainWindow main = new MainWindow();
        public static NewGameWindow newGameMenu = new NewGameWindow();
        public static ErrorWindow errorWindow = new ErrorWindow("title", "message");
        public static PlayerEntryWindow playerEntryWindow;
        public static GameWindow gameWindow;
    }
}
