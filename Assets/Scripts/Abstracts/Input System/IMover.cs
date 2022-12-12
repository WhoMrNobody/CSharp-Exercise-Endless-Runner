using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyCourse2.Abstracts.Movements
{
    public interface IMover
    {
        void FixedTick(float direction);
    }
}

