using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Paddle
{
    Vector2 _direction;
    IInput _input= new PcInput();
    private void Update()
    {
        
        if (_input.IsMoving)
        {
            Vector2 dir = _input.VerticalInput;
            if (dir.x < 0)
            {
                _direction = dir;  
            }           

        }

    }

    private void FixedUpdate()
    {
        _rigidbody.MovePosition(_rigidbody.position + _direction * this.speed * Time.fixedDeltaTime);
    }
}
