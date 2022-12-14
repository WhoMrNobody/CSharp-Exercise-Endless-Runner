using System.Collections;
using System.Collections.Generic;
using UdemyCourse2.Controller;
using UnityEngine;

namespace UdemyCourse2.ScriptableObjects
{
    [CreateAssetMenu(fileName ="Level Difficulty", menuName ="Create Difficulty/Create New", order = 0)]
    public class LevelDifficultyData : ScriptableObject
    {
        [SerializeField] FloorController _floorPrefab;
        [SerializeField] GameObject _spawners;
        [SerializeField] Material _skyboxMaterial;
        [SerializeField] float _moveSpeed = 10f;

        public FloorController FloorPrefab => _floorPrefab;
        public GameObject Spawners => _spawners;
        public Material SkyboxMaterial => _skyboxMaterial;
        public float MoveSpeed => _moveSpeed;
    }

}
