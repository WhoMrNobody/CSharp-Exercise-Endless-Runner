using System;
using System.Collections;
using System.Collections.Generic;
using UdemyCourse2.Managers;
using UnityEngine;

namespace UdemyCourse2.UIs
{
    public class GameCanvas : MonoBehaviour
    {
        [SerializeField] GameOverPanel _gameOverPanel;
        void Awake()
        {
            _gameOverPanel.gameObject.SetActive(false);
        }

        private void OnEnable()
        {
            GameManager.Instance.OnGameStop += HandleOnGameOver;
        }

        private void OnDisable()
        {
            GameManager.Instance.OnGameStop -= HandleOnGameOver;
        }
        private void HandleOnGameOver()
        {
            _gameOverPanel.gameObject.SetActive(true);
        }

    }


}
