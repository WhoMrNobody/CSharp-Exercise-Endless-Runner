using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyCourse2.Abstracts.Controllers
{
    public interface IEntityControllers
    {
        Transform transform { get; }
        float MoveSpeed { get; }
        float MoveBoundary { get; }
    }

}
