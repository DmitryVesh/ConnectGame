using System;

namespace ConnectFourGUI
{
    public class Board
    {
        public int xSize { get; }
        public int ySize { get; }
        public int maxMove { get; }
        private string[,] contents;
        private int[] xFillCount;
        public int connectNum { get; }
        private int[,] surroundCoord = new int[9, 2];

        public Board(int xSize, int ySize, int connectNum)
        {
            (this.xSize, this.ySize, this.connectNum) = (xSize, ySize, connectNum);
            contents = new string[xSize, ySize];
            xFillCount = new int[xSize];
            maxMove = xSize * ySize;
            AssignSurroundCoord();
        }

        public (int xSize, int ySize) GetBoardDimensions()
        {
            return (xSize, ySize);
        }
        public bool CheckIfValidMove(int x)
        {
            if (xFillCount[x] < ySize) { return true; }
            return false;
        }
        public void AddMove(int x, string color)
        {
            contents[x, ySize - 1 - xFillCount[x]] = color;
            xFillCount[x] += 1;
        }
        public int GetCurrentY(int x)
        {
            return ySize - 1 - xFillCount[x];
        }
        public int GetMaxInLineCounters(int x, string color)
        {
            int countsTogetherCurrent = 1;
            int countsTogetherMax = 1;

            int currentRowMove = GetCurrentY(x);
            int surroundCount;

            for (int winningDirections = 0; winningDirections < 4; winningDirections++)
            {
                surroundCount = winningDirections;
                for (int inLineCount = 0; inLineCount < 2; inLineCount++)
                {
                    for (int lineCount = 1; lineCount < connectNum; lineCount++)
                    {
                        try
                        {
                            if (contents[x + surroundCoord[surroundCount, 0] * lineCount, currentRowMove + surroundCoord[surroundCount, 1] * lineCount] == color) { countsTogetherCurrent += 1; }
                            else { break; }
                        }
                        catch (IndexOutOfRangeException) { break; }
                    }
                    surroundCount = 8 - surroundCount;
                }
                // May go over connectNum if more in line together
                if (countsTogetherCurrent > countsTogetherMax) { countsTogetherMax = countsTogetherCurrent; }
                countsTogetherCurrent = 1;
            }
            return countsTogetherMax;
        }
        private void AssignSurroundCoord()
        {
            int indexZero = 0, indexOne = 0;
            for (int countZero = -1; countZero < 2; countZero++)
            {
                for (int countOne = -1; countOne < 2; countOne++)
                {
                    surroundCoord[indexZero, indexOne] = countZero;
                    indexOne += 1;
                    surroundCoord[indexZero, indexOne] = countOne;
                    indexZero += 1;
                    indexOne = 0;
                }
            }
        }
    }
}
