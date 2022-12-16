using System.Collections;
using System.Collections.Generic;
using UdemyCourse2.Managers;
using UnityEngine;

namespace UdemyCourse2.UIs
{
    public class MenuPanel : MonoBehaviour
    {   
        public void DifficultySelect(int index)
        {
            GameManager.Instance.DifficultyIndex= index;
            GameManager.Instance.NextLoadScene("GameScene");
        }
        public void ExitGame()
        {
            GameManager.Instance.ExitGame();
        }

    }

}
