using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] List<Sprite> goalNumbers = new List<Sprite>();

    [SerializeField] private GameObject _endGameWin;
    [SerializeField] private GameObject _endGameLose;
    [SerializeField] private GameObject _quitInfo;




    public Sprite GetGoalNumber(int value)
    {
        return goalNumbers[value];
    }
    public void EndGame(bool isWin)
    {

        if (isWin)
        {
            _endGameWin.SetActive(true);
        }
        else
        {
            _endGameLose.SetActive(true);
        }

    }

    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void OptionsMenu()
    {

    }
    public void RetryGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void QuitInfo()
    {
        _quitInfo.SetActive(true);
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Continue()
    {
        _quitInfo.SetActive(false);
    }
}
