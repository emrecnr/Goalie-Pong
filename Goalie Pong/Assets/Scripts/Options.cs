using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Options : MonoBehaviour
{
    [Header("--- References --- ")]
    [SerializeField] private GameObject[] _onOffSprite;
    private void Start()
    {
        if (PlayerPrefs.GetFloat("GameMusic") == 1)
        {
            _onOffSprite[0].SetActive(true);
            _onOffSprite[1].SetActive(false);
        }
        else
        {
            _onOffSprite[1].SetActive(true);
            _onOffSprite[0].SetActive(false);
        }
    }
    public void ButtonProcess(string value)
    {
        switch (value)
        {
            case "On":
                _onOffSprite[0].SetActive(false);
                _onOffSprite[1].SetActive(true);
                PlayerPrefs.SetFloat("GameMusic", 0);
                SoundManager.Instance.GameMusicVolume();
                break;
            case "Off":
                _onOffSprite[0].SetActive(true);
                _onOffSprite[1].SetActive(false);
                PlayerPrefs.SetFloat("GameMusic", 1);
                SoundManager.Instance.GameMusicVolume();
                break;
        }
    }
}
