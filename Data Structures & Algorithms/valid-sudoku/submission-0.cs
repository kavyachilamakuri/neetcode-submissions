public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        for (int i = 0; i < 9; i++)
        {
            var row = board[i]
                .Where(x => x != '.')
                .GroupBy(x => x)
                .Any(g => g.Count() > 1);

            if (row) return false;

            var column = Enumerable.Range(0, 9)
                .Select(r => board[r][i])
                .Where(x => x != '.')
                .GroupBy(x => x)
                .Any(g => g.Count() > 1);

            if (column) return false;
        }

        for (int bRow = 0; bRow < 3; bRow++)
        {
            for (int bCol = 0; bCol < 3; bCol++)
            {
                var box = Enumerable.Range(0, 9)
                    .Select(i => board[bRow * 3 + i / 3][bCol * 3 + i % 3])
                    .Where(x => x != '.')
                    .GroupBy(x => x)
                    .Any(g => g.Count() > 1);

                if (box) return false;
            }
        }

        return true;
    }
}