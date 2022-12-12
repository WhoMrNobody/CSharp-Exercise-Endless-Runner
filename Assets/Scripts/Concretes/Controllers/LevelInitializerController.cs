using System.Collections;
using System.Collections.Generic;
using UdemyCourse2.Managers;
using UdemyCourse2.ScriptableObjects;
using UnityEngine;

namespace UdemyCourse2.Controller
{
    public class LevelInitializerController : MonoBehaviour
    {
        LevelDifficultyData _levelDifficultyData;

        private void Awake()
        {
            _levelDifficultyData = GameManager.Instance.LevelDifficultyData;
        }
        void Start()
        {
            RenderSettings.skybox = _levelDifficultyData.SkyboxMaterial;
            Instantiate(_levelDifficultyData.FloorPrefab);
            Instantiate(_levelDifficultyData.Spawners);
        }


    }

}
