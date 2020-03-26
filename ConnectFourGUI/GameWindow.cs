using System;
using System.Collections.Generic;
using System.Timers;
using Gtk;
using Gdk;

namespace ConnectFourGUI
{
    public partial class GameWindow : MyWindow
    {
        private int numHumanPlayers, numAIPlayers, numTotalPlayers, currentPlayerIndex = 0, waitTime = 1000, currentTurn = 1, currentTime = 0;
        private Player[] players;
        private Board board;
        private bool waitAfterAIMove;

        private Timer timer;
        private Gtk.Image[,] cells;
        private Table table;
        private EventBox[] eventBoxArray;
        
        public GameWindow(Player[] players, Board board, int numHumanPlayers, int numAIPlayers, bool waitAfterAIMove)
        {
            //game.PlayGame(numColumns, numRows, numConnectWin, numHumanPlayers, numAIPlayers, waitAfterAIMove, playerNames);
            this.players = players;
            this.board = board;
            this.numHumanPlayers = numHumanPlayers;
            this.numAIPlayers = numAIPlayers;
            this.numTotalPlayers = numHumanPlayers + numAIPlayers;
            this.waitAfterAIMove = waitAfterAIMove;
            timer = new Timer(waitTime);
            timer.Elapsed += UpdateTime;
            MakeWindow();
        }

        protected void MakeWindow()
        {
            int xSize, ySize;
            (xSize, ySize) = board.GetBoardDimensions();
            this.Build();
            table = new Table((uint)xSize, (uint)ySize, true); //6 rows, 7 columns, homogenous true - has all cells the same size
            eventBoxArray = new EventBox[xSize];
            for (int x = 0; x < xSize; x++)
            {
                eventBoxArray[x] = new EventBox()
                {
                    Name = $"eventBox{x}",
                };
                eventBoxArray[x].ButtonPressEvent += new ButtonPressEventHandler(OnColumnButtonPressEvent);
            }
            table.RowSpacing = 0;
            table.ColumnSpacing = 0;

            cells = new Gtk.Image[xSize, ySize];
            
            for (int y = 0; y < ySize; y++)
            {
                for (int x = 0; x < xSize; x++)
                {
                    Table.TableChild tempCellImage;
                    cells[x, y] = new Gtk.Image();
                    cells[x, y].Name = $"cell{x},{y}";
                    cells[x, y].Pixbuf = Pixbuf.LoadFromResource("ConnectFourGUI.bin.drawings.emptyTile.png");
                    if (y == ySize - 1)
                    {
                        eventBoxArray[x].Add(cells[x, y]);
                        table.Add(eventBoxArray[x]);
                        tempCellImage = (Table.TableChild)(table[eventBoxArray[x]]);
                    }
                    else
                    {
                        table.Add(cells[x, y]);
                        tempCellImage = (Table.TableChild)(table[cells[x, y]]);
                    }

                    //table.Attach(cells[x, y], (uint)x, (uint)x + 1, (uint)y, (uint)y + 1, (AttachOptions)(4), (AttachOptions)(4), (uint)4, (uint)4);
                    tempCellImage.TopAttach = ((uint)(y ));
                    tempCellImage.BottomAttach = ((uint)(y + 1));
                    tempCellImage.LeftAttach = ((uint)(x ));
                    tempCellImage.RightAttach = ((uint)(x + 1));
                    tempCellImage.YOptions = (AttachOptions)(4);
                    tempCellImage.XOptions = (AttachOptions)(4);
                }
            }

            this.GameBox.Add(this.table);
            Box.BoxChild w1 = (Box.BoxChild)GameBox[table];
            w1.Position = 0;
            w1.Expand = false;
            w1.Fill = false;
            turnLbl.Text = "0";
            
            this.ShowAll();
            UpdateWindowCurrents();
            timer.Enabled = true;
        }

        //ShowOnScreenCantAddCounterToThatColumn
        private void OnColumnButtonPressEvent(object o, ButtonPressEventArgs args)
        {
            string eventBoxName = ((EventBox)o).Name;
            int xMove = GetPlayerMoveX(eventBoxName);
            foreach (EventBox eventBox in eventBoxArray)
            {
                if (eventBox.Name == eventBoxName)
                {
                    if (board.CheckIfValidMove(xMove)) { AddMove(xMove); }
                    //else { ShowOnScreenCantAddCounterToThatColumn }
                }
            }
        }
        protected void OnExitBtnClicked(object sender, EventArgs e)
        {
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Logic

        private void AddMove(int x)
        {
            ChangeImage(cells[x, board.GetCurrentY(x)], players[currentPlayerIndex].counter);
            board.AddMove(x, players[currentPlayerIndex].color);
            //if (!CurrentMoveHuman()) { WaitAfterAIMove(); }
            currentPlayerIndex = (currentPlayerIndex + 1) % numTotalPlayers;
            UpdateWindowCurrents();
        }
        private int GetPlayerMoveX(string name)
        {
            return int.Parse(name.Substring(8));
        }

        public void Run()
        {
            //string winner = null;
            //do
            //{
                //if (players[currentPlayerIndex] is AI)
                //{
                    //AddMove(players[currentPlayerIndex].Move(board, players));
                //}
                //else
                //{
                    
                //}
            //} while (currentTurn < board.maxMove && winner == null);
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Graphics

        private void ChangeImage(Gtk.Image image, Pixbuf pixbuf)
        {
            image.Pixbuf = pixbuf;
            image.QueueDraw();
        }
        private void UpdateWindowCurrents()
        {
            currentPlayerNameLbl.Text = players[currentPlayerIndex].name + "'s Turn";
            ChangeImage(currentPlayerCounterImage, players[currentPlayerIndex].counter);
            turnLbl.Text = "Turn: " + (currentTurn++).ToString();
        }
        private void UpdateTime(object source, ElapsedEventArgs e)
        {
            timeLbl.Text = "Time: " + (currentTime++).ToString();
        }
 
    }
}
