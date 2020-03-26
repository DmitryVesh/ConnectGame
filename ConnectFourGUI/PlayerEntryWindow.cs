using System;
using System.Collections.Generic;
using Gtk;
using Gdk;

namespace ConnectFourGUI
{
    public partial class PlayerEntryWindow : MyWindow
    {
        // Need to fix color selections in MyComboBoxes
        // Still need to figure out how to communicate with just 1 combobox in an array

        // Need to fix the output of clashing names
        // Need to add cap to player names, max characters is 20

        private int numTotalPlayers, numHumanPlayers, numAIPlayers;

        private VBox mainHBox;

        private Alignment topAlignment;

        private VBox middleBox;
        private HBox[] HBoxArray;
        private Label[] LblArray;
        private Entry[] EntryArray;

        private MyComboBox[] ComboBoxArray;
        private string[] comboBoxColors = new string[] { "Red", "Blue", "Green", "Cyan", "Magenta", "Orange", "Purple", "Yellow",  "Grey", "Dark Blue", "Teal", "Salmon", "Pink", "Dark Green", "Brown" };

        private Alignment buttonAlignment;
        private Button okBtn;
        private Button cancelBtn;

        private Alignment bottomAlignment;

        private Player[] players;
        private Board board;
        private bool waitAfterAIMove;

        public PlayerEntryWindow(int numHumanPlayers, int numAIPlayers, Board board, bool waitAfterAIMove)
        {
            this.numTotalPlayers = numHumanPlayers + numAIPlayers;
            this.numHumanPlayers = numHumanPlayers;
            this.numAIPlayers = numAIPlayers;
            players = new Player[numTotalPlayers];
            this.board = board;
            this.waitAfterAIMove = waitAfterAIMove;
            MakeWindow();
            ShowWindow();
        }

        private void MakeWindow()
        {
            WindowPosition = (WindowPosition)1;
            Resizable = false;

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
            ComboBoxArray = new MyComboBox[numTotalPlayers];

            okBtn = new Button
            {
                Name = "okBtn",
                Label = "OK",
                WidthRequest = 60,
                HeightRequest = 35           
            };
            okBtn.Clicked += new EventHandler(OnOkBtnClicked);

            cancelBtn = new Button
            {
                Name = "cancelBtn",
                Label = "Cancel",
                WidthRequest = 60,
                HeightRequest = 35
            };
            cancelBtn.Clicked += new EventHandler(OnCancelBtnClicked);


            for (int playerCount = 0; playerCount < numTotalPlayers; playerCount++)
            {
                if (playerCount < numHumanPlayers)
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
                }
                else
                {
                    LblArray[playerCount] = new Label
                    {
                        Name = $"Lbl{playerCount}",
                        Text = $"AI_{playerCount - numHumanPlayers} name :"
                    };
                    EntryArray[playerCount] = new Entry
                    {
                        Name = $"Entry{playerCount}",
                        Text = $"AI_{playerCount - numHumanPlayers}"
                    };
                }

                ComboBoxArray[playerCount] = new MyComboBox(comboBoxColors, playerCount.ToString())
                {
                    Name = $"ComboBox{playerCount}"
                };

                ///////////////////////////////////////////////////////////////////////
                ComboBoxArray[playerCount].Changed += new EventHandler(ComboBoxChanged);
                ///////////////////////////////////////////////////////////////////////

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

        private void ComboBoxChanged(object sender, EventArgs e)
        {
            ChangeComboBoxes((MyComboBox)sender);
        }
        private void ChangeComboBoxes(MyComboBox activatedComboBox)
        {
            string activeValue = GetActiveValue(activatedComboBox);
            //LblArray[0].Text = activatedComboBox.id;
            for (int count = 0; count < numTotalPlayers; count++)
            {
                if (activatedComboBox.id != ComboBoxArray[count].id)
                {
                    ComboBoxArray[count].DeleteElement(activeValue);
                }
                else
                {
                    if (activatedComboBox.previousActiveText != "")
                    {
                        ComboBoxArray[count].DeleteElement(ComboBoxArray[count].previousActiveText);
                        for (int count2 = 0; count2 < numTotalPlayers; count2++)
                        {
                            ComboBoxArray[count2].AppendElement(ComboBoxArray[count].previousActiveText);
                        }
                    }
                    ComboBoxArray[count].previousActiveText = activeValue;
                }
            }
        }
        private string GetActiveValue(ComboBox comboBox)
        {
            return comboBox.ActiveText;
        }

        private void OnOkBtnClicked(object sender, EventArgs e)
        {
            string output = ValidateEntry();
            if (output == "")
            {
                string[] playerNames = GetPlayerNames();
                string[] playerColors = GetPlayerColors();
                Pixbuf[] playerCounters = ReturnPlayerCounters(playerColors);
                
                for (int count = 0; count < numTotalPlayers; count++)
                {
                    if (count < numHumanPlayers) { players[count] = new Player(playerNames[count], playerColors[count], playerCounters[count]); continue; }
                    players[count] = new AI(playerNames[count], playerColors[count], playerCounters[count]);
                }

                WindowClass.gameWindow = new GameWindow
                    (players,
                    board,
                    numHumanPlayers, numAIPlayers, waitAfterAIMove);
                WindowClass.gameWindow.Run();
                HideWindow();
            }
            else
            {
                //Show error window
                WindowClass.errorWindow.Destroy();
                WindowClass.errorWindow = new ErrorWindow("Player settings error", output);
                WindowClass.errorWindow.ShowWindow();
            }
        }
        private void OnCancelBtnClicked(object sender, EventArgs e)
        {
            Destroy();
            WindowClass.newGameMenu.ShowWindow();
        }

        private Pixbuf[] ReturnPlayerCounters(string[] colors)
        {
            //private List<string> colors = new List<string> { "Red", "Blue", "Green", "Cyan", "Magenta", "Orange", "Purple", "Yellow", "Grey", "Dark Blue", "Teal", "Salmon", "Pink", "Dark Green", "Brown" };
            Pixbuf[] counters = new Pixbuf[numTotalPlayers];
            List<string> presentList = new List<string>();

            string dir = "/Users/dmitry.veshchikov/Desktop/Code/CSharp/ConnectFourGUI/ConnectFourGUI/bin/drawings/";
            int squareImageLen = 50;

            for (int colorCount = 0; colorCount < numTotalPlayers; colorCount++)
            {
                foreach (string color in colors)
                {
                    if (presentList.Contains(color)) { continue; }

                    if (color == "Red") { counters[colorCount] = new Pixbuf(dir + "redCounter.png", squareImageLen, squareImageLen); presentList.Add(color); break; }
                    else if (color == "Blue") { counters[colorCount] = new Pixbuf(dir + "blueCounter.png", squareImageLen, squareImageLen); presentList.Add(color); break; }
                    else if (color == "Green") { counters[colorCount] = new Pixbuf(dir + "greenCounter.png", squareImageLen, squareImageLen); presentList.Add(color); break; }
                    else if (color == "Cyan") { counters[colorCount] = new Pixbuf(dir + "cyanCounter.png", squareImageLen, squareImageLen); presentList.Add(color); break; }
                    else if (color == "Magenta") { counters[colorCount] = new Pixbuf(dir + "magentaCounter.png", squareImageLen, squareImageLen); presentList.Add(color); break; }
                    else if (color == "Orange") { counters[colorCount] = new Pixbuf(dir + "orangeCounter.png", squareImageLen, squareImageLen); presentList.Add(color); break; }
                    else if (color == "Purple") { counters[colorCount] = new Pixbuf(dir + "purpleCounter.png", squareImageLen, squareImageLen); presentList.Add(color); break; }
                    else if (color == "Yellow") { counters[colorCount] = new Pixbuf(dir + "yellowCounter.png", squareImageLen, squareImageLen); presentList.Add(color); break; }
                    else if (color == "Grey") { counters[colorCount] = new Pixbuf(dir + "greyCounter.png", squareImageLen, squareImageLen); presentList.Add(color); break; }
                    else if (color == "Dark Blue") { counters[colorCount] = new Pixbuf(dir + "darkBlueCounter.png", squareImageLen, squareImageLen); presentList.Add(color); break; }
                    else if (color == "Teal") { counters[colorCount] = new Pixbuf(dir + "tealCounter.png", squareImageLen, squareImageLen); presentList.Add(color); break; }
                    else if (color == "Salmon") { counters[colorCount] = new Pixbuf(dir + "salmonCounter.png", squareImageLen, squareImageLen); presentList.Add(color); break; }
                    else if (color == "Pink") { counters[colorCount] = new Pixbuf(dir + "pinkCounter.png", squareImageLen, squareImageLen); presentList.Add(color); break; }
                    else if (color == "Dark Green") { counters[colorCount] = new Pixbuf(dir + "darkGreenCounter.png", squareImageLen, squareImageLen); presentList.Add(color); break; }
                    else if (color == "Brown") { counters[colorCount] = new Pixbuf(dir + "brownCounter.png", squareImageLen, squareImageLen); presentList.Add(color); break; }
                }
            }
            return counters;
        }
        private string[] GetPlayerColors()
        {
            string[] playerColors = new string[numTotalPlayers];
            List<string> present = new List<string>();

            for (int count = 0; count < numTotalPlayers; count++)
            {
                if (ComboBoxArray[count].ActiveText == null)
                {
                    foreach (string color in comboBoxColors)
                    {
                        bool added = false;
                        bool colorPresent = false;
                        if (present.Contains(color)) { continue; }
                        foreach (MyComboBox comboBox in ComboBoxArray)
                        {
                            if (comboBox.ActiveText == color)
                            {
                                colorPresent = true;
                                break;
                            }
                        }
                        if (!colorPresent)
                        {
                            present.Add(color);
                            playerColors[count] = color;
                            added = true;
                        }
                        if (added) { break; }
                    }
                }
                else { playerColors[count] = ComboBoxArray[count].ActiveText; present.Add(ComboBoxArray[count].ActiveText); }
            }
            return playerColors;
        }
        private string[] GetPlayerNames()
        {
            string[] playerNames = new string[numTotalPlayers];
            for (int count = 0; count < numTotalPlayers; count++)
            {
                playerNames[count] = EntryArray[count].Text;
            }
            return playerNames;
        }
        private string ValidateEntry()
        {
            string output = "";
            List<int> indexEmptyComboBoxes = new List<int>();
            List<int> indexEmptyEntryNames = new List<int>();
            List<List<int>> indexClashEntryNames = new List<List<int>>();

            indexEmptyComboBoxes = CheckComboBoxes(indexEmptyComboBoxes);
            indexEmptyEntryNames = CheckEntryNames(indexEmptyEntryNames);
            indexClashEntryNames = CheckClashEntryNames(indexClashEntryNames);

            if (indexEmptyComboBoxes.Count > 0)
            {
                output += "Human players : ";
                output += ReturnPlayerLblNames(indexEmptyComboBoxes);
                output += " haven't selected a color.\n\n";
            }
            if (indexEmptyEntryNames.Count > 0)
            {
                output += "Human players : ";
                output += ReturnPlayerLblNames(indexEmptyEntryNames);
                output += " haven't entered their name.\n\n";
            }
            if (indexClashEntryNames.Count > 0)
            {
                foreach (List<int> list in indexClashEntryNames)
                {
                    if (list.Count > 0)
                    {
                        output += "Players : ";
                        output += ReturnPlayerLblNames(list);
                        output += " have same names\n";
                    }
                }
            }
            return output;
        }
        private string ReturnPlayerLblNames(List<int> list)
        {
            string output = "";
            foreach (int index in list) { output += $" {LblArray[index].Text.Substring(0, LblArray[index].Text.Length - 6)}"; }
            return output;
        }
        private List<int> CheckComboBoxes(List<int> indexEmptyComboBoxes)
        {
            for (int playerCount = 0; playerCount < numHumanPlayers; playerCount++)
            {
                if (ComboBoxArray[playerCount].previousActiveText == "") { indexEmptyComboBoxes.Add(playerCount); }
            }
            return indexEmptyComboBoxes;
        }
        private List<int> CheckEntryNames(List<int> indexEmptyEntryNames)
        {
            for (int playerCount = 0; playerCount < numHumanPlayers; playerCount++)
            {
                if (EntryArray[playerCount].Text == null || EntryArray[playerCount].Text == "") { indexEmptyEntryNames.Add(playerCount); }
            }
            return indexEmptyEntryNames;
        }
        private List<List<int>> CheckClashEntryNames(List<List<int>> indexClashEntryNames)
        {

            for (int playerCountZero = 0; playerCountZero < numTotalPlayers; playerCountZero++)
            {
                indexClashEntryNames.Add(new List<int>());
                for (int playerCountOne = 0; playerCountOne < numTotalPlayers; playerCountOne++)
                {
                    if (playerCountZero == playerCountOne) { continue; }
                    if (EntryArray[playerCountZero].Text == EntryArray[playerCountOne].Text)
                    {
                        indexClashEntryNames[indexClashEntryNames.Count - 1].Add(playerCountZero);
                        indexClashEntryNames[indexClashEntryNames.Count - 1].Add(playerCountOne);
                    }
                }
                
            }
            return indexClashEntryNames;
        }
    }
}
