using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Custom namespaces
using User.PlayerInput;
public class Gameplay : MonoBehaviour
{
    Player player;
    Player enemy;
    bool isCurrentPlayer = true;
    public Player currentPlayer;
    public Sprite playerSprite;
    public Sprite enemySprite;

    public InputController playerInput;
    Gameboard gameboard;
    WinningStates winningStates;

    void Awake()
    {
        gameboard = GetComponent<Gameboard>();
        winningStates = GetComponent<WinningStates>();

        CreatePlayers();
        gameboard.CreateGameBoard();
    }
    void Start()
    {

    }

    public void PlayerChoice()
    {
        Collider2D selectedGrid = playerInput.GetPlayerSelectedGrid();
        if (selectedGrid != null)
        {
            if (!gameboard.CheckisBoardFull())
            {
                bool gridSaved = gameboard.SaveSelectedGrid(selectedGrid.gameObject, currentPlayer);

                if (gridSaved)
                {
                    if (winningStates.isTheCharacterWinning(gameboard.GameBoard, currentPlayer.value))
                    {
                        GameManager.Instance.ShowDebugMessages("The Winner is: " + currentPlayer.playerName);
                        GameManager.Instance.GameOver();
                        // Oyunu bitirme kodlarının yazılması gereken yer.
                    }
                    else
                    {
                        SwicthCharacter(currentPlayer.value);
                    }
                }

            }
            else
            {
                GameManager.Instance.ShowDebugMessages("The game is tie!");
                GameManager.Instance.GameOver();
            }
        }
    }

    public void CreatePlayers()
    {
        player = new Player("X", 1, isCurrentPlayer, playerSprite);
        enemy = new Player("O", -1, !isCurrentPlayer, enemySprite);

        currentPlayer = player;
    }

    void SwicthCharacter(int value)
    {

        if (value == 1)
        {
            enemy.isYourTurn = isCurrentPlayer;
            currentPlayer = enemy;
            GameManager.Instance.ShowDebugMessages("Enemy's Turn");

        }
        else
        {
            player.isYourTurn = isCurrentPlayer;
            currentPlayer = player;
            GameManager.Instance.ShowDebugMessages("Player's Turn");
        }
    }
}
