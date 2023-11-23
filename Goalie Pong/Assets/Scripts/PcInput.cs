using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PcInput : IInput

{
    public Vector2 VerticalInput { get => Camera.main.ScreenToWorldPoint(Input.mousePosition); }
    public bool IsMoving => Input.GetMouseButton(0);
}

