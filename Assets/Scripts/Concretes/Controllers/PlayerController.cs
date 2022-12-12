using System.Collections;
using System.Collections.Generic;
using UdemyCourse2.Abstracts.Controllers;
using UdemyCourse2.Abstracts.Input;
using UdemyCourse2.Abstracts.Movements;
using UdemyCourse2.Input;
using UdemyCourse2.Managers;
using UdemyCourse2.Movements;
using UnityEngine;
using UnityEngine.InputSystem;

namespace UdemyCourse2.Controller
{
    public class PlayerController : MyCharacterController, IEntityControllers
    {
        
        [SerializeField] float _jumpForce = 50f;
    
        IMover _mover;
        IJump _jumpWithRigidbody;
        IInputReader _iInputReader;
        float _horizontal;
        bool _isJump;
        bool _isDead = false;
        
        private void Awake()
        {
            _mover = new HorizontalMovements(this);
            _jumpWithRigidbody= new JumpWithRigidbody(this);
            _iInputReader = new InputReader(GetComponent<PlayerInput>());
        }

        private void Update()
        {
            if (_isDead) return;

            _horizontal = _iInputReader.HorizontalInput;

            if (_iInputReader.isJump) _isJump = true;
        }

        private void FixedUpdate()
        {   
            _mover.FixedTick(_horizontal);

            if(_isJump )
            {
                _jumpWithRigidbody.TickFixed(_jumpForce);
            }
            _isJump = false;
        }

        private void OnTriggerEnter(Collider coll)
        {
            if(coll.gameObject.tag == "Enemy")
            {
                GameManager.Instance.StopGame();
                _isDead= true;
            }
        }

    } //class

} //namespace

