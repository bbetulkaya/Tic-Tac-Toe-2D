using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CleanCode
{
    public class Player : Character, ICharacterStats
    {
        Sprite playerSprite;
        int playerValue = 1;
        void Start()
        {
            CreateCharacter("Player", playerSprite);
            ApplyCharacterStats(playerValue, true);
        }


        void Update()
        {
            // When player clicked the sprite call playerchoice method
            if (Input.GetMouseButtonDown(0) && isCurrentPlayer)
            {
                // gameplay.PlayerChoice();
            }
        }
    }
}