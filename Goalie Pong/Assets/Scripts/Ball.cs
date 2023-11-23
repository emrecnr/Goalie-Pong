using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;


    private Rigidbody2D _rigidbody;
    private Animator _animator;

    private Vector2 _startDirection;
    

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }
    
    private void Start()
    {
        StartCoroutine(StartingForce());
    }
    
    private void FixedUpdate()
    {
       
        _animator.SetFloat("movement",_rigidbody.velocity.x);
        SetRotation();
    }

    public IEnumerator StartingForce()
    {
        yield return new WaitForSeconds(2);
        float x = Random.value < 0.5f ? -1 : 1f;
        float y = Random.value < 0.5f ? Random.Range(-1f, -0.5f) :
                                        Random.Range(0.5f, 1f);
        _startDirection = new Vector2(x, y);
        _rigidbody.velocity = _startDirection* _moveSpeed;       
        
    }
    
    public void ResetPosition()
    {
        _rigidbody.position = Vector2.zero;
        _rigidbody.velocity = Vector2.zero;        
    }
    private void SetRotation()
    {
        if (_rigidbody.velocity.x > 0f)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 180f);
        }
    }
}
