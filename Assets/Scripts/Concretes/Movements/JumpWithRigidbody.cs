using System.Collections;
using System.Collections.Generic;
using UdemyCourse2.Abstracts.Movements;
using UdemyCourse2.Controller;
using UnityEngine;

namespace UdemyCourse2.Movements
{
    public class JumpWithRigidbody : IJump
    {
        Rigidbody _rigidBody;
        bool _canJump => _rigidBody.velocity.y != 0;
        public JumpWithRigidbody(PlayerController playerController)
        {
            _rigidBody = playerController.GetComponent<Rigidbody>();
        }

        public void TickFixed(float jumpForce)
        {
            if (_canJump) return;

            _rigidBody.velocity = Vector3.zero;
            _rigidBody.AddForce(Vector3.up * Time.deltaTime * jumpForce);

        }
    }
}

