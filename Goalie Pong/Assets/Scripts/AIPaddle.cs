using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPaddle : Paddle
{
    [SerializeField] private Rigidbody2D _rigidbodyBall;
    private void FixedUpdate()
    {
        if (this._rigidbodyBall.velocity.x > 0f)
        {
            if (this._rigidbodyBall.position.y > this._rigidbody.position.y + 0.5f)
            {
                _rigidbody.MovePosition(_rigidbody.position + Vector2.up * (this.speed * Time.fixedDeltaTime));
            }
            else if (this._rigidbodyBall.position.y < this._rigidbody.position.y + -0.5f)
            {
                _rigidbody.MovePosition(_rigidbody.position + Vector2.down * (this.speed * Time.fixedDeltaTime));
            }

        }
        else
        {
            if (this._rigidbody.position.y > 0.5f)
            {
                _rigidbody.MovePosition(_rigidbody.position + Vector2.down * (this.speed * Time.fixedDeltaTime));
            }
            else if (this._rigidbody.position.y < -0.5f)
            {
                _rigidbody.MovePosition(_rigidbody.position + Vector2.up * (this.speed * Time.fixedDeltaTime));
            }
            else
            {
                _rigidbody.MovePosition(_rigidbody.position + Vector2.zero * this.speed * Time.fixedDeltaTime);
                _rigidbody.velocity = Vector2.zero;
            }
           

        }
    }
}
