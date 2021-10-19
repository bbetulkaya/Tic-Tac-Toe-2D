using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public string playerName { get; set; }
    public Sprite playerSprite { get; set; }
    public int value { get; set; }
    public bool isYourTurn { get; set; }
    public Player[] players { get; set; }

    public Player(string playerName, int value, bool isYourTurn, Sprite playerSprite)
    {
        this.playerName = playerName;
        this.value = value;
        this.isYourTurn = isYourTurn;
        this.playerSprite = playerSprite;
    }

    public Player(int value, bool isYourTurn)
    {
        this.value = value;
        this.isYourTurn = isYourTurn;
    }
    public void AddPlayer(Player player)
    {
        players[value] = player;
    }
}
