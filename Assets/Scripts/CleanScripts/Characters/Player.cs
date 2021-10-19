using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CleanCode
{
    public class Player : Character, ICharacterStats
    {
        public Sprite playerSprite;
        int playerValue = 1;

        IGameplay gameplay;

        void Awake()
        {
            gameplay = GetComponentInChildren<IGameplay>();
        }
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
                gameplay.CharacterChosenMove(this);
            }
        }


    }
}
