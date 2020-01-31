using System;
using Gtk;
using ConnectFourGUI;

public partial class MainWindow : Gtk.Window
{

    NewGameWindow newGameMenu = new NewGameWindow();

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        ShowAll();
    }
    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnNewGameBtnClicked(object sender, EventArgs e)
    {
        //if (newGameMenu.deleted) { newGameMenu = new NewGameWindow(); }
        //if (!newGameMenu.showing) { newGameMenu.ShowWindow(); }

    }

    protected void OnLoadGameBtnClicked(object sender, EventArgs e)
    {

    }

    protected void OnSettingsBtnClicked(object sender, EventArgs e)
    {
    }

    protected void OnQuitBtnClicked(object sender, EventArgs e)
    {
        Application.Quit();
    }
}