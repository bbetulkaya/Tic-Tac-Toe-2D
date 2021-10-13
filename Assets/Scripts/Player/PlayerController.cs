using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Custom namespaces
// using User.PlayerInput;

namespace User.PlayerController
{
    public class PlayerController : MonoBehaviour
    {
        Player player;
        public Gameplay gameplay;

        void Start()
        {
            gameplay = GetComponentInChildren<Gameplay>();
            player = gameplay.currentPlayer;
        }


        void Update()
        {
            // WHEN THE ENEMY AI ADD DELETE THIS STATEMENT!!
            if (!player.isYourTurn)
            {
                player = gameplay.currentPlayer;
            }

            if (Input.GetMouseButtonDown(0) && player.isYourTurn)
            {
                gameplay.PlayerChoice();
            }
        }
    }
}
