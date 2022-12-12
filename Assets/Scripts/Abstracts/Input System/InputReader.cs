using System;
using System.Collections;
using System.Collections.Generic;
using UdemyCourse2.Abstracts.Input;
using UnityEngine;
using UnityEngine.InputSystem;

namespace UdemyCourse2.Input
{
    public class InputReader : IInputReader
    {
        PlayerInput _playerInput;

        public float HorizontalInput { get; private set; }
        public bool isJump { get; private set; }

        public InputReader(PlayerInput playerInput)
        {
            _playerInput = playerInput;

            _playerInput.currentActionMap.actions[0].performed += OnHorizontalMove;
            _playerInput.currentActionMap.actions[1].started += OnJump;
            _playerInput.currentActionMap.actions[1].canceled+= OnJump;
        }

        private void OnJump(InputAction.CallbackContext context)
        {
            isJump = context.ReadValueAsButton();
        }

        private void OnHorizontalMove(InputAction.CallbackContext context)
        {
            HorizontalInput = context.ReadValue<float>();
        }
    } //class
    
} //namespace

