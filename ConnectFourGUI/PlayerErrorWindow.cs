using System;
namespace ConnectFourGUI
{
    public partial class PlayersErrorWindow : MyWindows
    {
        public PlayersErrorWindow()
        {
            Build();
            errorMessageLbl.Text = "Error, the number of players entered is invalid...\nThe combined number of players, either AI or human players must be over 1...";
            HideWindow();
        }

        // Button clicks

        protected void OnOkBtnClicked(object sender, EventArgs e)
        {
            HideWindow();
        }
    }
}
