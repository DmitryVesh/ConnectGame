using System;
using Gtk;

namespace ConnectFourGUI
{
    public partial class NewGameWindow : MyWindow
    {
        //Need to check for valid connect number with the board dimensions entered
        public NewGameWindow()
        {
            Build();
            HideWindow();
        }

        private void OnStartGameBtnClicked(object sender, EventArgs e)
        {
            if (numHumanPlayersSpinBtn.Value + numAIPlayersSpinBtn.Value > 1)
            {
                WindowClass.errorWindow.HideWindow();

                HideWindow();

                int numRows = int.Parse(numRowsSpinBtn.Value.ToString());
                int numColumns = int.Parse(numColumnsSpinBtn.Value.ToString());
                int numCountersWin = int.Parse(numCountersWinSpinBtn.Value.ToString());
                Board board = new Board(numColumns, numRows, numCountersWin);

                int numHumanPlayers = int.Parse(numHumanPlayersSpinBtn.Value.ToString());
                int numAIPlayers = int.Parse(numAIPlayersSpinBtn.Value.ToString());

                bool boolWaitAfterAIMove;
                if (AIMoveWaitButton.Active) { boolWaitAfterAIMove = true; }
                else { boolWaitAfterAIMove = false; }

                //Activate window that asks for player names and colors
                WindowClass.playerEntryWindow = new PlayerEntryWindow(numHumanPlayers, numAIPlayers, board, boolWaitAfterAIMove);
                WindowClass.playerEntryWindow.ShowWindow();
            }
            else
            {
                WindowClass.errorWindow.Destroy();
                WindowClass.errorWindow = new ErrorWindow("Player number error", "Error, the number of players entered is invalid...\nThe combined number of players, either AI or human players must be over 1...");
                WindowClass.errorWindow.ShowWindow();
            }
        }
        private void OnCancelGameSettingsBtnClicked(object sender, EventArgs e)
        {
            HideWindow();
            WindowClass.main.ShowWindow();
        }
    }
}
