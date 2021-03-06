using System;
using UnityEngine;

public class Gameboard : MonoBehaviour
{
    public int[,] GameBoard { get; set; }

    public void CreateGameBoard()
    {
        GameBoard = new int[3, 3];

        // All elements default value is 0
        for (int i = 0; i < GameBoard.GetLength(0); i++)
        {
            for (int j = 0; j < GameBoard.GetLength(1); j++)
            {
                GameBoard[i, j] = 0;
            }
        }
    }
    public bool CheckIsPositionTaken(int currentPosValue)
    {
        if (currentPosValue == 0) { return false; } else {return true; }
    }

    public bool CheckisBoardFull()
    {
        int rowLength = GameBoard.GetLength(0);
        int colLength = GameBoard.GetLength(1);

        for (int i = 0; i < rowLength; i++)
        {
            for (int j = 0; j < colLength; j++)
            {
                if (GameBoard[i, j] == 0)
                    return false;
            }

        }
        return true;
    }

    public bool SaveSelectedGrid(GameObject grid, Character currentCharacter)
    {
        
        // Turn the grid name to integer
        int posCol = Int32.Parse(grid.name.Substring(0, 1));
        int posRow = Int32.Parse(grid.name.Substring(1));

        // Add x or y value to GridArray
        if (!CheckIsPositionTaken(GameBoard[posCol, posRow]))
        {
            GameBoard[posCol, posRow] = currentCharacter.value;
            grid.GetComponent<SpriteRenderer>().sprite = currentCharacter.characterSprite;
            return true;
            
        }
        else
        {
            return false;
        }

    }
}
