using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private GameObject _optionsPanel;
    [SerializeField] private GameObject _startPanel;

    private int _singlePlayerIndex = 1;
    private int _TwoPlayerIndex = 2;


    public void OptionsPanel(string value)
    {
        switch (value)
        {
            case "Open":
                _optionsPanel.SetActive(true);
                break;
            case "Close":
                _optionsPanel.SetActive(false);
                break;
        
        }

    }
    public void StartGame(string value)
    {
        switch (value)
        {
            case "Start":
                _startPanel.SetActive(true);
                break;
            case "Continue":
                _startPanel.SetActive(false);
                break;
            case "Single":
                SceneManager.LoadScene(_singlePlayerIndex);
                break;
            case "Two":
                SceneManager.LoadScene(_TwoPlayerIndex);
                break;
        }
    }
    
}
