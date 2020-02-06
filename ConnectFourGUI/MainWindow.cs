using System;
using Gtk;
using ConnectFourGUI;

public partial class MainWindow : MyWindows
{

    NewGameWindow newGameMenu = new NewGameWindow();

    public MainWindow()
    {
        Build();
        ShowWindow();
    }
    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    // Button clicks

    protected void OnNewGameBtnClicked(object sender, EventArgs e)
    {
        if (newGameMenu.IsDeleted()) { newGameMenu = new NewGameWindow(); }
        if (!newGameMenu.IsShowing()) { newGameMenu.ShowWindow(); }
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