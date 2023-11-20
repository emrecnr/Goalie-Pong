using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    private Rigidbody2D _rigidbody;
    private Vector2 _startDirection;
    

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        StartingForce();
    }

    private void StartingForce()
    {
        float x = Random.value < 0.5f ? -1 : 1f;
        float y = Random.value < 0.5f ? Random.Range(-1f, -0.5f) :
                                        Random.Range(0.5f, 1f);
        _startDirection = new Vector2(x, y);
        _rigidbody.velocity = _startDirection* _moveSpeed;
        
    }
}
