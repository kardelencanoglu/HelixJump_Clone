using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int score;

    public Text scoreText;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void GameScore (int circleScore) {
        score += circleScore;
        scoreText.text = score.ToString();
    }



    public void RestartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
