using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UdemyCourse2.Abstracts.Controllers;
using UdemyCourse2.Controller;
using UdemyCourse2.Abstracts.Movements;

namespace UdemyCourse2.Movements
{
    public class HorizontalMovements : IMover
    {
        IEntityControllers _playerController;
        float _moveSpeed;
        float _moveBoundary;
        public HorizontalMovements(IEntityControllers iEntityControllers)
        {
            _playerController = iEntityControllers;
            _moveSpeed = iEntityControllers.MoveSpeed;
            _moveBoundary = iEntityControllers.MoveBoundary;
        }

        public void FixedTick(float horizontal)
        {
            if (horizontal == 0) return;
            _playerController.transform.Translate(Vector3.right * horizontal * Time.deltaTime * _moveSpeed);

            float xBoundary = Mathf.Clamp(_playerController.transform.position.x, -_moveBoundary, _moveBoundary);
            _playerController.transform.position = new Vector3(xBoundary, _playerController.transform.position.y, 0);
        }
    }

}
