using System;
using System.Collections;
using System.Collections.Generic;
using UdemyCourse2.Abstracts.Controllers;
using UdemyCourse2.Enums;
using UdemyCourse2.Managers;
using UdemyCourse2.Movements;
using UnityEngine;

namespace UdemyCourse2.Controller
{
    public class EnemyController : MyCharacterController, IEntityControllers
    {
        [SerializeField] float _maxLifeTime = 7f;
        [SerializeField] EnemyEnum _enemyEnum;

        public EnemyEnum EnemyType => _enemyEnum;

        VerticalMover _verticalMover;
        float _currentLifeTime;
        private void Awake()
        {
            _verticalMover = new VerticalMover(this);
            _currentLifeTime = 0f;
        }

        private void Update()
        {
            _currentLifeTime += Time.deltaTime;
            if(_currentLifeTime > _maxLifeTime)
            {
                _currentLifeTime = 0f;
                DestroyTheEnemy();
            }
        }

        private void FixedUpdate()
        {
            _verticalMover.FixedTick();
        }

        private void DestroyTheEnemy()
        {
            EnemyManager.Instance.SetPool(this);
        }

        public void SetMoveSpeed(float moveSpeed )
        {
            if (moveSpeed < _moveSpeed) return;
            _moveSpeed= moveSpeed;
        }
    }
}

