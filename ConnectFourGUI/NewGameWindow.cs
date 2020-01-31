using System;
namespace ConnectFourGUI
{
    public partial class NewGameWindow : Gtk.Window
    {
        public NewGameWindow() : base(Gtk.WindowType.Toplevel)
        {
            Build();
        }
    }
}
