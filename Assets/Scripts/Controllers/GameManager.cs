using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Controller.GameManager
{
    public class GameManager : MonoBehaviour
    {
        private static GameManager instance;

        private GameManager()
        {
            // initialize your game manager here. Do not reference to GameObjects here (i.e. GameObject.Find etc.)
            // because the game manager will be created before the objects
        }

        public static GameManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameManager();
                }

                return instance;
            }
        }

        void SetUpTheGame()
        {
            // Create Player
            // Create Gameboard
        }

        void StartTheGame()
        {
            // Choice the player
            // Set the player sprite and other things
            // Begin the GameLoop

        }
        void GameLoop()
        {
            // Choice the next move
            // Check the winning states
            // Wait the enemy's move
            // LOOP
        }
    }
}
