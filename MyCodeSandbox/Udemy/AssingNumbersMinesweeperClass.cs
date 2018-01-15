using System;
using System.Collections.Generic;

namespace MyCodeTestSandbox
{
    public class AssingNumbersMinesweeperClass
    {
        public void Run()
        {
            var bombs = new List<KeyValuePair<int, int>> {
                new KeyValuePair<int, int>(0, 0),
                new KeyValuePair<int, int>(0, 1)
            };

            var bombField = AssignNumbersMinesweeper(bombs, 3, 4);

            PrintBombField(bombField);
        }

        public int[,] AssignNumbersMinesweeper(List<KeyValuePair<int, int>> p_Bombs, int p_Rows, int p_Cols)
        {
            var bombField = new int[p_Rows, p_Cols];
            
            foreach(var pair in p_Bombs)
            {
                bombField[pair.Key, pair.Value] = -1;
                IncrementNearFields(pair.Key, pair.Value, bombField);
            }

            return bombField;
        }

        private void IncrementNearFields(int p_BombRow, int p_BombCol, int[,] p_BombField)
        {
            int maxRow = p_BombField.GetLength(0);
            int maxCol = p_BombField.GetLength(1);

            for (int row = p_BombRow -1; row <= p_BombRow +1; row++)
                if(row >= 0 && row < maxRow)
                    for (int col = p_BombCol - 1; col <= p_BombCol + 1; col++)
                        if (col >= 0 && col < maxCol)
                        {
                            if (p_BombField[row, col] != -1)
                                p_BombField[row, col] += 1;
                        }
        }

        private void PrintBombField(int[,] p_Field)
        {
            int rowLength = p_Field.GetLength(0);
            int colLength = p_Field.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", p_Field[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }
    }
}
