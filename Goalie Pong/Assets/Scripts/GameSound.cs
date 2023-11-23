using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSound : MonoBehaviour
{
    [SerializeField] private AudioSource _balHit;

    

    public void BallHitSound()
    {
        _balHit.Play(); 
    }
}
