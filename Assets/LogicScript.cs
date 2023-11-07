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
    public GameObject homeScreen;
    public MainScreen mainScreen;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        startGame();

    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        mainScreen.pause();        
        
    }
    public void quitGame()
    {
        Application.Quit();
    }

    [ContextMenu("Remove title")]
    public void startGame()
    {
        homeScreen.SetActive(false);
        scoreText.gameObject.SetActive(true);
        mainScreen.resumeGame();
       
    }

}
