using System.Collections;
using System.Collections.Generic;
using UdemyCourse2.Abstracts.Utilities;
using UdemyCourse2.ScriptableObjects;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UdemyCourse2.Managers
{
    public class GameManager : SingletonMonoBehaviourObject<GameManager>
    {
        [SerializeField] LevelDifficultyData[] _levelDifficultyDatas;

        public LevelDifficultyData LevelDifficultyData => _levelDifficultyDatas[0];

        public event System.Action OnGameStop;
        private void Awake()
        {
            SingletonThisObject(this);
        }

        public void StopGame()
        {   
            OnGameStop?.Invoke();
            Time.timeScale = 0f;
        }

        public void NextLoadScene(string sceneName)
        {
            StartCoroutine(LoadSceneAsync(sceneName));
        }

        IEnumerator LoadSceneAsync(string sceneName)
        {   
            Time.timeScale = 1f;
            yield return SceneManager.LoadSceneAsync(sceneName);
        }

        public void ExitGame()
        {
            Application.Quit();
        }
    }

}
