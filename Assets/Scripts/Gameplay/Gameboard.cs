using System;
using UnityEngine;

public class Gameboard : MonoBehaviour
{
    public int[,] GAMEBOARD { get; set; }

    public void CreateGameBoard()
    {
        GAMEBOARD = new int[3, 3];

        // All elements default value is minus one
        for (int i = 0; i < GAMEBOARD.GetLength(0); i++)
        {
            for (int j = 0; j < GAMEBOARD.GetLength(1); j++)
            {
                GAMEBOARD[i, j] = 0;
            }
        }
    }
    public bool CheckIsPositionTaken(int currentPosValue)
    {
        if (currentPosValue == 0) { return false; } else { Debug.Log("The position's is taken"); return true; }
    }

    public bool CheckisBoardFull()
    {
        int rowLength = GAMEBOARD.GetLength(0);
        int colLength = GAMEBOARD.GetLength(1);

        for (int i = 0; i < rowLength; i++)
        {
            for (int j = 0; j < colLength; j++)
            {
                if (GAMEBOARD[i, j] == 0)
                    return false;
            }

        }
        return true;
    }

    public void SaveSelectedGrid(GameObject grid)
    {

    }

    // public void SaveSelectedGrid(GameObject grid, Character character)
    // {
    //     // Turn the grid name to integer
    //     int posCol = Int32.Parse(grid.name.Substring(0, 1));
    //     int posRow = Int32.Parse(grid.name.Substring(1));

    //     // Add x or y value to GridArray

    //     if (!CheckIsPositionTaken(GAMEBOARD[posCol, posRow]))
    //     {
    //         GAMEBOARD[posCol, posRow] = character.value;
    //         grid.GetComponent<SpriteRenderer>().sprite = character.playerSprite;
    //         character.isYourTurn = false;
    //     }
    //     else
    //     {
    //         Debug.Log("Yeniden deneyin");
    //     }

    // }
}
