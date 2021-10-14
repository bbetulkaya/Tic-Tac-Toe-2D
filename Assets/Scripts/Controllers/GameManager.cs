using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Custom namespaces
using Controllers.UI;
public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public UIController uIController;
    private void Awake()
    {
        _instance = this;
    }
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                // instance = new GameManager();
                Debug.Log("There is no Game Manager");
            }

            return _instance;
        }
    }
    // private GameManager()
    // {
    //     // initialize your game manager here. Do not reference to GameObjects here (i.e. GameObject.Find etc.)
    //     // because the game manager will be created before the objects
    // }

    public void Pause()
    {

    }

    public void GameOver()
    {
        uIController.GameOverPanel();
        // Debug.Log("Pause");
    }

    void SetUpTheGame()
    {
        // Create Player
        // Create Gameboard
    }

    void StartTheGame()
    {
        // Choice the player
        // Set the player sprite and other things
        // Begin the GameLoop

    }
    void GameLoop()
    {
        // Choice the next move
        // Check the winning states
        // Wait the enemy's move
        // LOOP
    }
    public void ReloadTheGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}