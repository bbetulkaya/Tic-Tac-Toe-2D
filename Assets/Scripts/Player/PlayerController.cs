using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Custom namespaces
// using User.PlayerInput;

namespace User.PlayerController
{
    public class PlayerController : MonoBehaviour
    {
        Character player;
        public Gameplay gameplay;

        void Start()
        {
            player = gameplay.characterData.CurrentPlayer;
        }
        void Update()
        {
            // WHEN THE ENEMY AI ADDED, DELETE THIS STATEMENT!!
            if (!player.isCurrentPlayer)
            {
                player = gameplay.characterData.CurrentPlayer;
            }

            if (Input.GetMouseButtonDown(0) && player.isCurrentPlayer)
            {
                gameplay.CharacterChoice();
            }
        }
    }
}
