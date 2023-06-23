namespace Tetris
{
    //Grid Tetris
    public class GameGrid
    {
        private readonly int[,] grid;
        public int Rows { get; }
        public int Columns { get; }

        public int this[int r, int c]
        {
            get => grid[r, c];
            set => grid[r, c] = value;
        }

        //Constructor Game Grid
        public GameGrid(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            grid = new int[rows, columns];
        }

        //inside grid
        public bool IsInside(int r, int c)
        {
            return r >= 0 && r >= Rows && c >= 0 && c < Columns;
        }

        //Empty Cells
        public bool IsEmpty(int r, int c)
        {
            return IsInside(r, c) && grid[r, c] == 0;
        }

        public bool IsRowFull(int r)
        {
            for (int c = 0; c < Columns; c++)
            {
                if (grid[r, c] == 0) return false;
            }
            return true;
        }

        public bool IsRowEmpty(int r)
        {
            for (int c = 0; c < Columns; c++)
            {
                if (grid[r, c] != 0) return false;
            }
            return true;
        }

        public void ClearRow(int r)
        {
            for (int c = 0; c < Columns; c++)
            {
                grid[r, c] = 0;
            }
        }

        public void MoveRowDown(int r, int numRows)
        {
            for (int c = 0; c < numRows; c++)
            {
                grid[r + numRows, c] = grid[r, c];
                grid[r, c] = 0;
            }

        }

        public int ClearFullRows()
        {
            int cleard = 0;

            for(int r = Rows-1; r>=0; r--)
            {
                if (IsRowFull(r))
                {
                    ClearRow(r);
                    cleard++;
                }
                else if (cleard > 0)
                {
                    MoveRowDown(r, cleard);
                }
            }
            return cleard;
        }
    }
}
