using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;
    public AudioSource _gameMusic;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        if (PlayerPrefs.HasKey("GameMusic"))
        {
            _gameMusic.volume = PlayerPrefs.GetFloat("GameMusic");
        }
        else
        {
           PlayerPrefs.SetFloat("GameMusic",1f);
        }
    }

    private void Update()
    {
        //GameMusicVolume();
    }
    public void GameMusicVolume()
    {
        
        if (PlayerPrefs.HasKey("GameMusic"))
        {
            _gameMusic.volume = PlayerPrefs.GetFloat("GameMusic");
        }
        else
        {
            PlayerPrefs.SetFloat("GameMusic", 1f);
        }
    }
}
