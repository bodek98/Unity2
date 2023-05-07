using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public GameObject loseUI;
    public int points = 0;
    public int highestScore;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highestScoreText;

    public void StartGame()
    {
        Time.timeScale = 1;
        highestScore = PlayerPrefs.GetInt ("highestScore", highestScore);
        highestScoreText.text = "HighScore: " + highestScore;
        
    }

    private void ShowLoseUI()
    {
        loseUI.SetActive(true);
    }

    public void RepeatGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
        highestScore = PlayerPrefs.GetInt ("highestScore", highestScore);
        highestScoreText.text = "HighScore: " + highestScore.ToString();
    }
    public void OnGameOver()
    {
        ShowLoseUI();
        if (points > highestScore)
        {
            highestScore = points;
            highestScoreText.text = "HighScore: " + highestScore.ToString();
            PlayerPrefs.SetInt ("highestScore", highestScore);
        }
        Time.timeScale = 0;
    }

    public void UpdateScore()
    {
        points++;
        scoreText.text = points.ToString();
    }
}
