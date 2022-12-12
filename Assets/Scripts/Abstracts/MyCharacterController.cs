using System.Collections;
using System.Collections.Generic;
using UdemyCourse2.Movements;
using UnityEngine;

namespace UdemyCourse2.Abstracts.Controllers
{
    public abstract class MyCharacterController : MonoBehaviour
    {
        [SerializeField] float _moveBoundary = 4.5f;
        [SerializeField] float _moveSpeed;

        public float MoveSpeed => _moveSpeed;
        public float MoveBoundary => _moveBoundary;
    }
}

