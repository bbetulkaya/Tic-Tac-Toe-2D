using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCreator : MonoBehaviour
{
    public Sprite playerSprite;
    public Sprite enemySprite;

    public bool isCurrentCharacter = true;
    int _characterDefaultValue = 1;

    public void CreateCharacters(CharacterData characterData)
    {
        characterData.Player = new Character("X", _characterDefaultValue, isCurrentCharacter, playerSprite);
        characterData.Enemy = new Character("O", -_characterDefaultValue, !isCurrentCharacter, enemySprite);

        characterData.CurrentPlayer = characterData.Player;

        Debug.Log(characterData.CurrentPlayer.characterName);
    }
}