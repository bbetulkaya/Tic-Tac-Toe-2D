using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;
namespace Controllers.UI
{
    public class UIController : MonoBehaviour
    {
        public List<GameObject> panels = new List<GameObject>();
        public TMP_Text notificationText;

        void Start()
        {
            CloseAllPanel();
        }

        // Example panels for the UI
        public void GameOverPanel()
        {
            GameObject panel = panels.ElementAt(1);
            panel.SetActive(true);
            Debug.Log("Game is Over");
        }
        void CloseAllPanel()
        {

            for (int i = 0; i < panels.Count(); i++)
            {
                GameObject panel = panels.ElementAt(i);
                panel.SetActive(false);
            }

        }

        public void DebugToTxt(string msg)
        {
            GameObject notificationPanel = panels.ElementAt(0);
            notificationPanel.SetActive(true);
            notificationText.text = msg;

            StartCoroutine("PanelScreenTime", 0);

        }

        IEnumerator PanelScreenTime(int index)
        {
            yield return new WaitForSeconds(1.5f);
            panels.ElementAt(index).SetActive(false);
        }
    }
}