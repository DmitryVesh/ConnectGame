using System;
using Gtk;
using Gdk;

namespace ConnectFourGUI
{

    public class Player
    {
        public string name { get; }
        public string color { get; }
        public Pixbuf counter { get; }

        public Player(string name, string color, Pixbuf counter) => (this.name, this.color, this.counter) = (name, color, counter);
        public virtual int Move(Board board, Player[] players) { return -1; }
    }

    public class AI : Player
    {
        public AI(string name, string color, Pixbuf counter) : base(name, color, counter)
        {
            //Could make different types of AI using different strategies
        }
        public override int Move(Board board, Player[] players)
        {
            int bestScore = -100, bestMove = 0, score;

            for (int count = 0; count < board.xSize; count++)
            {
                score = CalculateScoreOfMove(count, board, players);
                if (score > bestScore) { bestScore = score; bestMove = count; }
            }

            return bestMove;
        }
        private int CalculateScoreOfMove(int x, Board board, Player[] players)
        {
            int score = 0;
            if (board.CheckIfValidMove(x))
            {
                int connectNum = board.connectNum;

                for (int count = 0; count < players.Length; count++)
                {
                    if (players[count].name != name)
                    {
                        int oppScore = board.GetMaxInLineCounters(x, players[count].color);
                        if (oppScore >= connectNum) { score += 500; }
                        if (oppScore == connectNum - 1) { score += 8; }
                        if (oppScore == connectNum - 2) { score += 2; }
                    }
                }

                board.AddMove(x, color);
                int inLineCountMy = board.GetMaxInLineCounters(x, color);
                

                if (inLineCountMy >= connectNum) { score += 1000; }
                if (inLineCountMy == connectNum - 1) { score += 9; }
                if (inLineCountMy == connectNum - 2) { score += 8; }
                if (x == board.xSize / 2) { score += 4; }

                for (int count = 0; count < players.Length; count++)
                {
                    if (players[count].name != name)
                    {
                        int oppScore = board.GetMaxInLineCounters(x, players[count].color);
                        if (oppScore >= connectNum) { score -= 5000; }
                        if (oppScore == connectNum - 1) { score -= 8; }
                        if (oppScore == connectNum - 2) { score -= 2; }
                    }
                }
            }
            else { score = -9999; }
            return score;
        }
    }
}
