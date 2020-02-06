using System;
using Gtk;

namespace ConnectFourGUI
{
    public partial class PlayerEntryWindow : MyWindows
    {
        private int numTotalPlayers, numHumanPlayers, numAIPlayers;

        private VBox mainHBox;

        private Alignment topAlignment;

        private VBox middleBox;
        private HBox[] HBoxArray;
        private Label[] LblArray;
        private Entry[] EntryArray;
        private ComboBox[] ComboBoxArray;

        private Alignment buttonAlignment;
        private Button okBtn;
        private Button cancelBtn;

        private Alignment bottomAlignment;


        public PlayerEntryWindow(int numHumanPlayers, int numAIPlayers)
        {
            this.numTotalPlayers = numHumanPlayers + numAIPlayers;
            this.numHumanPlayers = numHumanPlayers;
            this.numAIPlayers = numAIPlayers;
            MakeWindow();
            ShowAll();
            
        }


        protected void MakeWindow()
        {
            this.Resizable = false;
            //SetDefaultSize(700, 700);

            topAlignment = new Alignment(0.5F, 0.5F, 1F, 1F)
            {
                HeightRequest = 10
            };
            bottomAlignment = new Alignment(0.5F, 0.5F, 1F, 1F)
            {
                HeightRequest = 10
            };
            buttonAlignment = new Alignment(0.5F, 0.5F, 1F, 1F)
            {
                WidthRequest = 200
            };

            mainHBox = new VBox
            {
                Name = "mainBox"
            };
            middleBox = new VBox
            {
                Name = "middleBox"
            };
            HBoxArray = new HBox[numTotalPlayers + 1];
            LblArray = new Label[numTotalPlayers];
            EntryArray = new Entry[numTotalPlayers];
            ComboBoxArray = new ComboBox[numTotalPlayers];

            okBtn = new Button
            {
                Name = "okBtn",
                Label = "OK",
                WidthRequest = 60,
                HeightRequest = 35
            };

            cancelBtn = new Button
            {
                Name = "cancelBtn",
                Label = "Cancel",
                WidthRequest = 60,
                HeightRequest = 35
            };



            for (int playerCount = 0; playerCount < numHumanPlayers; playerCount++)
            {
                LblArray[playerCount] = new Label
                {
                    Name = $"Lbl{playerCount}",
                    Text = $"Player_{playerCount} name :"
                };

                EntryArray[playerCount] = new Entry
                {
                    Name = $"Entry{playerCount}"
                };

                ComboBoxArray[playerCount] = new ComboBox(new string[] { "hello", "ooff" })
                {
                    Name = $"ComboBox{playerCount}"
                };

                HBoxArray[playerCount] = new HBox
                {
                    Name = $"HBox{playerCount}"
                };

                HBoxArray[playerCount].Add(LblArray[playerCount]);
                HBoxArray[playerCount].Add(EntryArray[playerCount]);
                HBoxArray[playerCount].Add(ComboBoxArray[playerCount]);

                middleBox.Add(HBoxArray[playerCount]);

            }

            for (int playerCount = numHumanPlayers; playerCount < numTotalPlayers; playerCount++)
            {
                LblArray[playerCount] = new Label
                {
                    Name = $"Lbl{playerCount}",
                    Text = $"AI_{playerCount - numHumanPlayers} name :"
                };

                EntryArray[playerCount] = new Entry
                {
                    Name = $"Entry{playerCount}",
                    Text = $"AI{playerCount - numHumanPlayers}"
                };

                ComboBoxArray[playerCount] = new ComboBox(new string[] { "hello", "ooff" })
                {
                    Name = $"ComboBox{playerCount}"
                };

                HBoxArray[playerCount] = new HBox
                {
                    Name = $"HBox{playerCount}"
                };

                HBoxArray[playerCount].Add(LblArray[playerCount]);
                HBoxArray[playerCount].Add(EntryArray[playerCount]);
                HBoxArray[playerCount].Add(ComboBoxArray[playerCount]);

                middleBox.Add(HBoxArray[playerCount]);
            }
            HBoxArray[numTotalPlayers] = new HBox()
            {
                Name = "buttonHBox"
            };
            HBoxArray[numTotalPlayers].Add(buttonAlignment);
            HBoxArray[numTotalPlayers].Add(cancelBtn);
            HBoxArray[numTotalPlayers].Add(okBtn);
            middleBox.Add(HBoxArray[numTotalPlayers]);

            mainHBox.Add(topAlignment);
            mainHBox.Add(middleBox);
            mainHBox.Add(bottomAlignment);

            Add(mainHBox);
        }
    }
}
