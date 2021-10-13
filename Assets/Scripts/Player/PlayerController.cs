using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Custom namespaces
// using User.PlayerInput;

namespace User.PlayerController
{
    public class PlayerController : MonoBehaviour
    {
        public Gameplay gameplay;

        void Start()
        {
            gameplay = GetComponentInChildren<Gameplay>();
        }


        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                gameplay.PlayerChoice();
            }
        }
    }
}
