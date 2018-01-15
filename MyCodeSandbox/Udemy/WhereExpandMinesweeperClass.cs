using System;
using System.Collections.Generic;

namespace MyCodeTestSandbox
{
    public class WhereExpandMinesweeperClass
    {
        public void Run()
        {
            var bombField = CreateBombField();
            PrintBombField(bombField);
        }

        private int[,] WhereExpandMinesweeper(int[,] p_Field, int p_ClickRow, int p_ClickCol)
        {
            int rowLength = p_Field.GetLength(0);
            int colLength = p_Field.GetLength(1);

            if (p_Field[p_ClickRow, p_ClickCol] == -1)
                return p_Field;

            return p_Field;
        }

        private List<KeyValuePair<int, int>> GetAdjacentsZeroPoints(int[,] p_Field, int p_Row, int p_Col)
        {
            var list = new List<KeyValuePair<int, int>>();
            int rowLength = p_Field.GetLength(0);
            int colLength = p_Field.GetLength(1);

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    if( i != 0 || j != 0)
                    {
                        if (PointIsOnBoundaries(p_Field, p_Row + i, p_Col + j))
                        {
                            if (p_Field[p_Row + i, p_Col + j] == 0)
                            {
                                list.Add(new KeyValuePair<int, int>(p_Row + i, p_Col + j));
                            }
                        }
                    }
                }
            }

            return list;
        }

        private bool PointIsOnBoundaries(int[,] p_Field, int p_Row, int p_Col)
        {
            int rowLength = p_Field.GetLength(0);
            int colLength = p_Field.GetLength(1);

            if (p_Row >= rowLength ||
                p_Row < 0 ||
                p_Col >= colLength ||
                p_Col < 0)
                return false;
            else
                return true;
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

        private int[,] CreateBombField()
        {
            var bombs = new List<KeyValuePair<int, int>> {
                new KeyValuePair<int, int>(2, 2)
            };

            var fieldBuilder = new AssingNumbersMinesweeperClass();
            return fieldBuilder.AssignNumbersMinesweeper(bombs, 3, 5);
        }
    }
}
