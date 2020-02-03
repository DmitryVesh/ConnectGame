using System;

namespace ConnectFourGUI
{
    public partial class NewGameWindow : Gtk.Window
    {
        NotEnoughPlayersDialog notEnoughPlayersMessage = new NotEnoughPlayersDialog();
        public bool showing, deleted;

        public int numRows, numColumns, numCountersWin, numHumanPlayers, numAIPlayers;
        public bool boolWaitAfterAIMove;

        public NewGameWindow() : base(Gtk.WindowType.Toplevel)
        {
            BuildWindow();
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

        protected void OnCancelGameSettingsBtnClicked(object sender, EventArgs e)
        {
            showing = WindowControls.HideWindow(this);
        }

        protected void OnStartGameBtnClicked(object sender, EventArgs e)
        {

            if (numHumanPlayersSpinBtn.Value + numAIPlayersSpinBtn.Value > 1)
            {
                notEnoughPlayersMessage.showing = WindowControls.HideWindow(notEnoughPlayersMessage);
                showing = WindowControls.HideWindow(this);

                numRows = int.Parse(numRowsSpinBtn.Value.ToString());
                numColumns = int.Parse(numColumnsSpinBtn.Value.ToString());
                numCountersWin = int.Parse(numCountersWinSpinBtn.Value.ToString());
                numHumanPlayers = int.Parse(numHumanPlayersSpinBtn.Value.ToString());
                numAIPlayers = int.Parse(numAIPlayersSpinBtn.Value.ToString());

                if (AIMoveWaitButton.Active) { boolWaitAfterAIMove = true; }
                else { boolWaitAfterAIMove = false; }

            }
            else
            {
                if (notEnoughPlayersMessage.deleted) { notEnoughPlayersMessage = new NotEnoughPlayersDialog(); }
                notEnoughPlayersMessage.showing = WindowControls.ShowWindow(notEnoughPlayersMessage);
            }
            
        }
    }
}
