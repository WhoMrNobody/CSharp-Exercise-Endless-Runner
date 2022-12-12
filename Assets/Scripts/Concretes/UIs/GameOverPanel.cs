using System.Collections;
using System.Collections.Generic;
using UdemyCourse2.Managers;
using UnityEngine;

namespace UdemyCourse2.UIs
{
    public class GameOverPanel : MonoBehaviour
    {
        public void PlayAgain()
        {
            GameManager.Instance.NextLoadScene("GameScene");
        }

        public void Exit()
        {
            GameManager.Instance.NextLoadScene("MainMenuScene");
        }
    }

}
