using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player.InputController
{


    public class InputController : MonoBehaviour
    {

        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                GameBoardInput();
            }
        }


        public void GameBoardInput()
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            Debug.Log(hit.collider != null);
            // return hit;
        }
    }
}