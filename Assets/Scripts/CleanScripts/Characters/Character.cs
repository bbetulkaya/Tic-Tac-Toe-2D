using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CleanCode
{
    public class Character : MonoBehaviour, ICharacterStats
    {
        public string characterName { get; set; }
        public Sprite characterSprite { get; set; }

        public int characterValue { get; set; }
        public bool isCurrentPlayer { get; set; }

        protected void CreateCharacter(string characterName, Sprite characterSprite)
        {
            this.characterName = characterName;
            this.characterSprite = characterSprite;
        }

        public void ApplyCharacterStats(int value, bool isCurrentPlayer)
        {
           this.characterValue = value;
           this.isCurrentPlayer = isCurrentPlayer;
        }
    }
}