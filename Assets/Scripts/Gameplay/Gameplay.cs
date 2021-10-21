using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Custom namespaces
using User.PlayerInput;
public class Gameplay : MonoBehaviour
{
    public InputController CharacterInput;
    public CharacterData characterData;
    Gameboard gameboard;
    WinningStates winningStates;
    CharacterCreator characterCreator;
    CharacterSwicther characterSwicther;

    void Awake()
    {
        gameboard = GetComponent<Gameboard>();
        winningStates = GetComponent<WinningStates>();
        characterCreator = GetComponent<CharacterCreator>();
        characterSwicther = GetComponent<CharacterSwicther>();
        characterData = GetComponent<CharacterData>();

        gameboard.CreateGameBoard();
        characterCreator.CreateCharacters(characterData);
    }

    public void CharacterChoice()
    {
        Collider2D selectedGrid = CharacterInput.GetSelectedGrid();
        if (selectedGrid != null)
        {
            bool gridSaved = gameboard.SaveSelectedGrid(selectedGrid.gameObject, characterData.CurrentPlayer);

            if (gridSaved)
            {
                if (winningStates.isTheCharacterWinning(gameboard.GameBoard, characterData.CurrentPlayer.value))
                {
                    // Oyunu bitirme kodlarının yazılması gereken yer.
                    GameManager.Instance.ShowDebugMessages("The Winner is: " + characterData.CurrentPlayer.characterName);
                    GameManager.Instance.GameOver();

                }
                else
                {
                    if (IsGameContinuing())
                    {
                        characterSwicther.SwicthCharacter(characterData);
                    }
                    else
                    {
                        GameManager.Instance.ShowDebugMessages("The game is tie!");
                        GameManager.Instance.GameOver();
                    }
                }
            }
            else
            {
                GameManager.Instance.ShowDebugMessages("Position is taken! Try Again..");
            }
        }
    }

    bool IsGameContinuing()
    {
        if (!gameboard.CheckisBoardFull())
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
