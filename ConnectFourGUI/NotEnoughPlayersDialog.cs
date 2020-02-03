using System;

namespace ConnectFourGUI
{
    public partial class NotEnoughPlayersDialog : Gtk.Dialog
    {
        public bool showing, deleted;

        public NotEnoughPlayersDialog()
        {
            Build();
            showing = WindowControls.HideWindow(this);
            DeleteEvent += delegate { DeleteWindow(); };
        }

        public void BuildWindow()
        {
            Build();
            showing = WindowControls.HideWindow(this);
            deleted = false;
        }
        protected void DeleteWindow()
        {
            deleted = true;
            showing = false;
        }

        protected void OnButtonOkClicked(object sender, EventArgs e)
        {
            showing = WindowControls.HideWindow(this);
        }
    }
}
