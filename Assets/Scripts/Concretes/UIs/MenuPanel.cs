using System.Collections;
using System.Collections.Generic;
using UdemyCourse2.Managers;
using UnityEngine;

namespace UdemyCourse2.UIs
{
    public class MenuPanel : MonoBehaviour
    {
        public void StartGame()
        {
            GameManager.Instance.NextLoadScene("GameScene");
        }

        public void ExitGame()
        {
            GameManager.Instance.ExitGame();
        }

    }

}
