using System;
using Gtk;
using ConnectFourGUI;

public partial class MainWindow : MyWindow
{
    public MainWindow()
    {
        Build();
        ShowWindow();
        WindowClass.gameWindow = new GameWindow
        (
            new Player[] { new Player("Tom", "Red", new Gdk.Pixbuf("/Users/dmitry.veshchikov/Desktop/Code/CSharp/ConnectFourGUI/ConnectFourGUI/bin/drawings/redCounter.png", 50, 50)),
                new Player("Ginger", "Blue", new Gdk.Pixbuf("/Users/dmitry.veshchikov/Desktop/Code/CSharp/ConnectFourGUI/ConnectFourGUI/bin/drawings/blueCounter.png", 50, 50)) },
            new Board(7, 6, 4),
            0, 2, true
        );
        WindowClass.gameWindow.Run();
    }
    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnNewGameBtnClicked(object sender, EventArgs e)
    {
        if (WindowClass.newGameMenu.IsDeleted()) { WindowClass.newGameMenu = new NewGameWindow(); HideWindow(); }
        if (!WindowClass.newGameMenu.IsShowing()) { WindowClass.newGameMenu.ShowWindow(); HideWindow(); }
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