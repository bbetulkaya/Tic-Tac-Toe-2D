using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSwicther : MonoBehaviour
{
    public void SwicthCharacter(CharacterData characterData)
    {
        if (characterData.CurrentPlayer.characterName == "X")
        {
            characterData.CurrentPlayer = characterData.Enemy;
        }
        else
        {
            characterData.CurrentPlayer = characterData.Player;
        }

    }
}