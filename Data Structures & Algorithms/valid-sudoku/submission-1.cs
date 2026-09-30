public class Solution {
    public bool IsValidSudoku(char[][] board) {
        for (int x = 0; x < 9; x++) {
            bool[] checks = new bool[9];
            for (int y = 0; y < 9; y++) {
                if (board[x][y] != '.') {
                    if (checks[board[x][y] - '1'])
                        return false;
                    checks[board[x][y] - '1'] = true;
                }
            }
        }

        for (int x = 0; x < 9; x++) {
            bool[] checks = new bool[9];
            for (int y = 0; y < 9; y++) {
                if (board[y][x] != '.') {
                    if (checks[board[y][x] - '1'])
                        return false;
                    checks[board[y][x] - '1'] = true;
                }
            }
        }

        for (int x1 = 0; x1 < 3; x1++) {
            for (int y1 = 0; y1 < 3; y1++) {
                bool[] checks = new bool[9];
                for (int x2 = 0; x2 < 3; x2++) {
                    for (int y2 = 0; y2 < 3; y2++) {
                        if (board[x1*3+x2][y1*3+y2] != '.') {
                            if (checks[board[x1*3+x2][y1*3+y2] - '1'])
                                return false;
                            checks[board[x1*3+x2][y1*3+y2] - '1'] = true;
                        }
                    }
                }
            }
        }

        return true;
    }
}
