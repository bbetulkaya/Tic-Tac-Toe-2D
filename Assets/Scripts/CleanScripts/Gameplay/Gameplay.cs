using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Custom namespaces
using User.PlayerInput;

namespace CleanCode
{
    public class Gameplay : MonoBehaviour
    {
        // Player and Enemy can control the gameplay!
        // So gameplay scrip can not create characters.
        Gameboard gameboard;
        WinningStates winningStates;

        public InputController playerInput;
        void Awake()
        {
            gameboard = GetComponent<Gameboard>();
            winningStates = GetComponent<WinningStates>();

            gameboard.CreateGameBoard();
        }

        public void CharacterChosenMove(Character character)
        {
            Collider2D selectedGrid = playerInput.GetPlayerSelectedGrid();
            if (selectedGrid != null)
            {
                bool gridSaved = gameboard.SaveSelectedGrid(selectedGrid.gameObject, character);
            }
        }

        // public void PlayerChoice()
        // {
        //     // Grid selection
        //     Collider2D selectedGrid = playerInput.GetPlayerSelectedGrid();
        //     if (selectedGrid != null)
        //     {
        //         bool gridSaved = gameboard.SaveSelectedGrid(selectedGrid.gameObject, currentPlayer);
        //         // Grid Selection

        //         // If grid is selected make the chosen move : CONTROL STATE
        //         if (gridSaved)
        //         {

        //             // Control the character is winning
        //             if (winningStates.isTheCharacterWinning(gameboard.GameBoard, currentPlayer.value))
        //             {
        //                 // Oyunu bitirme kodlarının yazılması gereken yer.
        //                 GameManager.Instance.ShowDebugMessages("The Winner is: " + currentPlayer.playerName);
        //                 GameManager.Instance.GameOver();

        //             }
        //             else
        //             {

        //                 // Control the game still continuing
        //                 if (IsGameContinuing())
        //                 {
        //                     SwicthPlayer(currentPlayer.value);
        //                 }
        //                 else
        //                 {
        //                     GameManager.Instance.ShowDebugMessages("The game is tie!");
        //                     GameManager.Instance.GameOver();
        //                 }
        //             }
        //         }

        //         else
        //         {
        //             GameManager.Instance.ShowDebugMessages("Position is taken! Try Again..");
        //         }
        //     }
        // }

    }
}