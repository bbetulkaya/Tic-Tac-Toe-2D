using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterData : MonoBehaviour
{
    private Character _player;
    private Character _enemy;
    private Character _currentPlayer;


    public Character Player { get { return _player; } set { _player = value; } }
    public Character Enemy { get { return _enemy; } set { _enemy = value; } }
    public Character CurrentPlayer { get { return _currentPlayer; } set { _currentPlayer = value; } }
}