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
        
        public VerticalMover(IEntityControllers iEntityController)
        {
            _iEntityController = iEntityController;
            
        }

        public void FixedTick(float vertical = 1f)
        {
            _iEntityController.transform.Translate(Vector3.back * vertical * _iEntityController.MoveSpeed * Time.deltaTime);
        }

    }

}
