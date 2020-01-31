using System;
namespace ConnectFourGUI
{
    public partial class NewGameWindow : Gtk.Window
    {
        public bool showing, deleted;

        public NewGameWindow() : base(Gtk.WindowType.Toplevel)
        {
            BuildWindow();
            DeleteEvent += delegate { DeleteWindow(); };
        }
        public void BuildWindow()
        {
            Build();
            HideWindow();
            deleted = false;
        }

        protected void DeleteWindow()
        {
            deleted = true;
            showing = false;
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
        protected void OnCancelGameSettingsBtnClicked(object sender, EventArgs e)
        {
            HideWindow();
        }

        protected void OnStartGameBtnClicked(object sender, EventArgs e)
        {
            HideWindow();
        }
    }
}
