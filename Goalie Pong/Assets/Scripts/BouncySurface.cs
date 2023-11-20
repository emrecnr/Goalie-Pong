using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    [Range(0,100)]
    [SerializeField] private float _bounceStrength;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Rigidbody2D ballRigidbody = collision.gameObject.GetComponent<Rigidbody2D>();
            if (ballRigidbody != null)
            {

                Vector2 ballPos = transform.position;
                Vector2 objectPos = collision.transform.position;

                float xDirection, yDirection;

                if (transform.position.x > 0)
                {
                    xDirection = -1;
                }
                else
                {
                    xDirection = 1;
                }
                yDirection = (ballPos.y - objectPos.y) / collision.transform.GetComponent<Collider2D>().bounds.size.y;
                if (yDirection == 0)
                {
                    yDirection = 0.25f;
                }
                ballRigidbody.velocity = new Vector2(xDirection, yDirection) * _bounceStrength;
            }




        }
    }
}
