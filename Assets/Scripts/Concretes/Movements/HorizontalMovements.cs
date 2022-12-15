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
        IEntityControllers _iEntityController;
        public HorizontalMovements(IEntityControllers iEntityControllers)
        {
            _iEntityController = iEntityControllers;
        }

        public void FixedTick(float horizontal)
        {
            if (horizontal == 0) return;
            _iEntityController.transform.Translate(Vector3.right * horizontal * Time.deltaTime * _iEntityController.MoveSpeed);

            float xBoundary = Mathf.Clamp(_iEntityController.transform.position.x, -_iEntityController.MoveBoundary, _iEntityController.MoveBoundary);
            _iEntityController.transform.position = new Vector3(xBoundary, _iEntityController.transform.position.y, 0);
        }
    }

}
