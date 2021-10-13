using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningStates : MonoBehaviour
{
    public bool isTheCharacterWinning(int[,] GameBoard, int value)
    {
        int win;
        int[,] gameBoard = GameBoard;
        int rowLength = gameBoard.GetLength(0);
        int colLength = gameBoard.GetLength(1);

        win = (value > 0) ? 3 : -3;

        bool row = CheckingRow(gameBoard, win, rowLength, colLength);
        bool col = CheckingCol(gameBoard, win, rowLength, colLength);
        bool diagonal = CheckingDiagonal(gameBoard, win, rowLength);
        bool antiDiagonal = CheckingAntiDiagonal(gameBoard, win, rowLength);

        if (row || col || diagonal || antiDiagonal) { return true; } else { return false; }

    }
    private bool CheckingRow(int[,] gameBoard, int win, int rowLength, int colLength)
    {
        int sum;
        // Check the row for winning
        for (int i = 0; i < rowLength; i++)
        {
            sum = 0;
            for (int j = 0; j < colLength; j++)
            {
                sum += gameBoard[i, j];
            }

            if (sum == win)
            {
                return true;
            }
        }
        return false;
    }

    private bool CheckingCol(int[,] gameBoard, int win, int rowLength, int colLength)
    {
        int sum;
        // Check the col for winning
        for (int i = 0; i < rowLength; i++)
        {
            sum = 0;
            for (int j = 0; j < colLength; j++)
            {
                sum += gameBoard[j, i];
            }

            if (sum == win)
            {
                return true;
            }
        }
        return false;
    }

    private bool CheckingDiagonal(int[,] gameBoard, int win, int rowLength)
    {
        int sum = 0;
        // Check the diagonal for winning
        for (int i = 0; i < rowLength; i++)
        {
            sum += gameBoard[i, i];

        }
        if (sum == win)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    private bool CheckingAntiDiagonal(int[,] gameBoard, int win, int rowLength)
    {
        int sum = 0;
        // Check the anti-diagnonal for winning
        for (int i = 0; i < rowLength; i++)
        {
            int jvalue = rowLength - 1;
            sum += gameBoard[jvalue - i, i];

        }
        if (sum == win)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
