using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    private UIManager _uiManager;

    [SerializeField] private Paddle _playerPaddle;
    [SerializeField] private Paddle _computerPaddle;

    private int _playerScore = 0;
    private int _computerScore = 0;

    [SerializeField] private TMP_Text _playerScoreText;
    [SerializeField] private TMP_Text _computerScoreText;
    [SerializeField] private GameObject _goalTextObject;

    [SerializeField] Image _goalImagePlayer;
    [SerializeField] Image _goalImageComputer;
   
    public bool isGameOver;



    private void Awake()
    {
        _uiManager = GetComponent<UIManager>();
    }
    private void Start()
    {
        _goalImagePlayer.sprite = _uiManager.GetGoalNumber(_playerScore);

        _goalImageComputer.sprite = _uiManager.GetGoalNumber(_computerScore);
    }
    public void PlayerScores()
    {
        _playerScore++;
        if (_playerScore > 9)
        {
            EndGameScore(true);
            return;
        }
        _goalImagePlayer.sprite = _uiManager.GetGoalNumber(_playerScore);
        StartCoroutine(ResetRound());
    }
    public void ComputerScores()
    {
        _computerScore++;
        if (_computerScore > 9)
        {
            EndGameScore(false);
            return;
        }
        _goalImageComputer.sprite = _uiManager.GetGoalNumber(_computerScore);
        StartCoroutine(ResetRound());
    }
    private void EndGameScore(bool winner)
    {
        isGameOver = true;

        if (winner)
        {
            _uiManager.EndGame(true);
        }
        else
        {
            _uiManager.EndGame(false);
        }
    }
    IEnumerator ResetRound()
    {
        _goalTextObject.SetActive(true);
        _playerPaddle.ResetPosition();
        _computerPaddle.ResetPosition();
        this.ball.ResetPosition();
        BouncySurface[] bouncys = FindObjectsOfType<BouncySurface>();
        for (int i = 0; i < bouncys.Length; i++)
        {
            bouncys[i]._bounceStrength = 4f;
        }
        yield return this.ball.StartingForce();


    }

}
