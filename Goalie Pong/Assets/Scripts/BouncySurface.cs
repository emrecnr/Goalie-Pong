using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    [Range(0,100)]
    public float _bounceStrength = 4f ;
    [SerializeField] private GameSound _sound;
    

     private Animator _animator;
     private float _hitCount = 0.5f;
    private void Awake()
    {
        _animator = GetComponentInChildren<Animator>();   
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Rigidbody2D ballRigidbody = collision.gameObject.GetComponent<Rigidbody2D>();
            if (ballRigidbody != null && _animator!=null)
            {
                _sound.BallHitSound();
                _animator.SetTrigger("Hit");
                 _bounceStrength += _hitCount;
                Vector2 ballPos = collision.transform.position;
                Vector2 objectPos = 
                    
                    transform.position;

                float xDirection, yDirection;

                if (transform.position.x > 0)
                {
                    xDirection = -1;
                }
                else
                {
                    xDirection = 1;
                }
                yDirection = (ballPos.y - objectPos.y) / GetComponent<Collider2D>().bounds.size.y;
                if (yDirection == 0)
                {
                    yDirection = 0.25f;
                }
                ballRigidbody.velocity = new Vector2(xDirection, yDirection) * _bounceStrength;
            }




        }
    }

    
}
