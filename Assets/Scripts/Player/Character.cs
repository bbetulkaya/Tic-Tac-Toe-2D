using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string characterName { get; set; }
    public Sprite characterSprite { get; set; }
    public int value { get; set; }
    public bool isCurrentPlayer { get; set; }

    public Character[] characters { get; set; }

    public Character(string characterName, int value, bool isYourTurn, Sprite characterSprite)
    {
        this.characterName = characterName;
        this.value = value;
        this.isCurrentPlayer = isYourTurn;
        this.characterSprite = characterSprite;
    }

    public void AddCharacter(Character character)
    {
        characters[value] = character;
    }
}
