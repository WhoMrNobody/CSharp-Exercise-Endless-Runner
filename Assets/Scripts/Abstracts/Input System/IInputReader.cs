using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyCourse2.Abstracts.Input
{
    public interface IInputReader 
    {
        float HorizontalInput { get; }
        bool isJump { get; }

    } //class

} //namespace

