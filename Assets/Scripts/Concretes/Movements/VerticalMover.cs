using System.Collections;
using System.Collections.Generic;
using UdemyCourse2.Abstracts.Movements;
using UdemyCourse2.Abstracts.Controllers;
using UdemyCourse2.Controller;
using UnityEngine;

namespace UdemyCourse2.Movements
{
    public class VerticalMover : IMover
    {
        IEntityControllers _iEntityController;
        float _moveSpeed;
        public VerticalMover(IEntityControllers iEntityController)
        {
            _iEntityController = iEntityController;
            _moveSpeed= _iEntityController.MoveSpeed;
        }

        public void FixedTick(float vertical = 1f)
        {
            _iEntityController.transform.Translate(Vector3.back * vertical * _moveSpeed * Time.deltaTime);
        }

    }

}
