using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
namespace Controllers.UI
{
    public class UIController : MonoBehaviour
    {
        public List<GameObject> Panels = new List<GameObject>();
        public Button restart;
        // Start is called before the first frame update
        void Start()
        {
            CloseAllPanel();
        }

        // Update is called once per frame
        void Update()
        {

        }


        // Example panels for the UI
        public void GameOverPanel()
        {
            GameObject panel = Panels.ElementAt(0);
            panel.SetActive(true);
            Debug.Log("Game is Over");
        }
        void Menu()
        {

        }
        void DebugMessages()
        {

        }

        void CloseAllPanel()
        {
            GameObject panel = Panels.ElementAt(0);
            panel.SetActive(false);
        }

    }
}