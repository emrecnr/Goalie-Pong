using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInput
{
    bool IsMoving { get; }
    Vector2 VerticalInput { get; }
}
