using System;
using Gtk;

namespace ConnectFourGUI
{
    public partial class ErrorWindow : Window
    {
        public ErrorWindow(string title, string message) : base(Gtk.WindowType.Toplevel)
        {
            Title = title;
            Build();
            errorMessageLbl.Text = message;
            HideWindow();
        }

        // Button clicks
        public void HideWindow()
        {
            Hide();
        }
        public void ShowWindow()
        {
            ShowAll();
        }
        protected void OnOkBtnClicked(object sender, EventArgs e)
        {
            HideWindow();
        }
    }
}
