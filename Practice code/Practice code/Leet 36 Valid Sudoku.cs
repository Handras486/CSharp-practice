using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_code
{
    internal class Leet_36_Valid_Sudoku
    {
        public static bool IsValidSudoku(char[][] board)
        {
            HashSet<char>[] rows = new HashSet<char>[9];
            HashSet<char>[] columns = new HashSet<char>[9];
            HashSet<char>[] boxes = new HashSet<char>[9];

            for (int k = 0; k < 9; k++)
            {
                rows[k] = new HashSet<char>();
                columns[k] = new HashSet<char>();
                boxes[k] = new HashSet<char>();
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i][j] == '.')
                        continue;

                    if (!rows[i].Add(board[i][j]))
                        return false;

                    if (!columns[j].Add(board[i][j]))
                        return false;

                    int b = (3 * (i / 3) + (j / 3));
                    if (!boxes[b].Add(board[i][j]))
                        return false;
                }
            }
            return true;
        }
    }
}
