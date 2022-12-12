using System.Collections;
using System.Collections.Generic;
using UdemyCourse2.Enums;
using UdemyCourse2.Managers;
using UnityEngine;

namespace UdemyCourse2.Controller
{
    public class SpawnController : MonoBehaviour
    {
        [Range(0.1f, 5f)][SerializeField] float _min = 0.1f;
        [Range(6f, 12f)][SerializeField] float _max = 12f;

        float _maxSpawnTime;
        float _currentSpawnTime = 0f;
        int _index = 0;
        float _maxAddEnemyTime;
        public bool CanIncrease => _index < EnemyManager.Instance.Count;
        void OnEnable()
        {
            GetRandomMaxTime();
        }

        void Update()
        {
            _currentSpawnTime += Time.deltaTime;

            if(_currentSpawnTime > _maxSpawnTime)
            {
                Spawn();
            }

            if(!CanIncrease) { return; }

            if(_maxAddEnemyTime < Time.time)
            {
                _maxAddEnemyTime = Time.time + EnemyManager.Instance.AddDelayTime;
                IncreaseIndex();
            }
        }

        private void IncreaseIndex()
        {
            if(CanIncrease)
            {
                _index++;
            }
        }

        private void Spawn()
        {
            EnemyController newEnemy = EnemyManager.Instance.GetPool((EnemyEnum)Random.Range(0, _index));
            newEnemy.transform.parent = this.transform;
            newEnemy.transform.position = this.transform.position;
            newEnemy.gameObject.SetActive(true);

            _currentSpawnTime = 0f;
            GetRandomMaxTime();
        }

        private void GetRandomMaxTime()
        {
            _maxSpawnTime = Random.Range(_min, _max);
        }
    }

}
