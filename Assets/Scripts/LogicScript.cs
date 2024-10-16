using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public Text winText;
    public Button playAgainButton;

    void Start()
    {
        winText.gameObject.SetActive(false);
        playAgainButton.gameObject.SetActive(false);
        Time.timeScale = 1f;
    }

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();

        if (playerScore == 5)
        {
            Time.timeScale = 0f;
            winText.text = "You Win!";  
            winText.gameObject.SetActive(true);
            playAgainButton.gameObject.SetActive(true);
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }

    public void gameOver()
    {
        Time.timeScale = 0f;
        gameOverScreen.SetActive(true);
    }
}

