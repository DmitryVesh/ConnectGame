using System;

namespace ConnectFourGUI
{
    public partial class NewGameWindow : MyWindows
    {
        PlayersErrorWindow playerErrorWindow = new PlayersErrorWindow();
        PlayerEntryWindow playerEntryWindow;

        public int numRows, numColumns, numCountersWin, numHumanPlayers, numAIPlayers;
        public bool boolWaitAfterAIMove;

        public NewGameWindow()
        {
            Build();
            HideWindow();
        }

        // Button clicks

        protected void OnCancelGameSettingsBtnClicked(object sender, EventArgs e)
        {
            HideWindow();
        }

        protected void OnStartGameBtnClicked(object sender, EventArgs e)
        {

            if (numHumanPlayersSpinBtn.Value + numAIPlayersSpinBtn.Value > 1)
            {
                playerErrorWindow.HideWindow();
                HideWindow();

                numRows = int.Parse(numRowsSpinBtn.Value.ToString());
                numColumns = int.Parse(numColumnsSpinBtn.Value.ToString());
                numCountersWin = int.Parse(numCountersWinSpinBtn.Value.ToString());
                numHumanPlayers = int.Parse(numHumanPlayersSpinBtn.Value.ToString());
                numAIPlayers = int.Parse(numAIPlayersSpinBtn.Value.ToString());

                if (AIMoveWaitButton.Active) { boolWaitAfterAIMove = true; }
                else { boolWaitAfterAIMove = false; }

                //Activate window that asks for player names and colours
                playerEntryWindow = new PlayerEntryWindow(numHumanPlayers, numAIPlayers);
                playerEntryWindow.ShowWindow();

            }
            else
            {
                if (playerErrorWindow.IsDeleted()) { playerErrorWindow = new PlayersErrorWindow(); }
                playerErrorWindow.ShowWindow();
            }
            
        }
    }
}
