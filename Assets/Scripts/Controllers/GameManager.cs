using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Custom namespaces
using Controllers.UI;
public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    UIController uIController;
    private void Awake()
    {
        _instance = this;
        
        uIController = GetComponentInChildren<UIController>();
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

    public void GameOver()
    {
        uIController.GameOverPanel();
        // Debug.Log("Pause");
    }
    public void ShowDebugMessages(string msg)
    {
        uIController.DebugToTxt(msg);
    }

    public void ReloadTheGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}