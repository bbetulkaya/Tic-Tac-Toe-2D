using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Custom namespaces
using User.PlayerInput;
public class Gameplay : MonoBehaviour
{
    public InputController playerInput;
    Gameboard gameboard;

    void Start()
    {
        gameboard = GetComponentInChildren<Gameboard>();
    }

    public void PlayerChoice()
    {
        Collider2D selectedGrid = playerInput.GetPlayerSelectedGrid();
        if (selectedGrid != null)
        {
            Debug.Log("true");
        }
    }
}
