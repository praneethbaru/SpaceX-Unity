using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public  class GameManager : MonoBehaviour {

    private bool gameHasEnded = false;
    private bool isLevelComplete = false;

    private int endScene = 7;
    private int survivalScene = 6;

    public float restartDelay = 0f;
    public static float score;
    public static float countLives = 5;
    public static float scoreCarry = 0.0f;

    public GameObject levelCompleteUI;
    public GameObject obstaclePieces;

    public Transform player;

    public Text score1;
    public Text livesCount;

    public void Start()
    {
        try
        {
            livesCount.text = countLives.ToString("0");
        }
        catch (System.NullReferenceException)
        {
            throw;
        }

    }
    void Update()
    {
        //if not end scene, keep adding
        if (SceneManager.GetActiveScene().buildIndex >= 1 && SceneManager.GetActiveScene().buildIndex <= 5)
        {
            if(!gameHasEnded || !isLevelComplete)
            {
                score = score + Time.deltaTime * 1.0f;
                score1.text = score.ToString("0");
            }

            else if(gameHasEnded || isLevelComplete)
            {
                //score = score;
                score1.enabled = false;
                score1.text = " ";
            }
        }

        if(SceneManager.GetActiveScene().buildIndex == survivalScene)
        {
            if (!gameHasEnded || !isLevelComplete)
            {
                score = score + Time.deltaTime * 1.0f;
                score1.text = score.ToString("0");
            }

            else if (gameHasEnded || isLevelComplete)
            {
                //score = score;
                score1.enabled = false;
                score1.text = " ";
            }
        }

        //else don't add
        if(SceneManager.GetActiveScene().buildIndex == endScene)
        {
            score1.text = score.ToString("0");
        }
        /*
        if(SceneManager.GetActiveScene().buildIndex > 1 && SceneManager.GetActiveScene().buildIndex<4)
        {
            if (!gameHasEnded || !isLevelComplete)
            {
                score = score + Time.deltaTime * 1.0f;
                score1.text = score.ToString("0");
            }

            else if (gameHasEnded || isLevelComplete)
            {
                score1.enabled = false;
                score1.text = " ";
            }
        }
        */

    }
    public void OnDestroy()
    {
    }

    public void LevelComplete()
    {
        score = score - 6; //earlier 12
        scoreCarry = score;
        isLevelComplete = true;
        levelCompleteUI.SetActive(true);
    }

   

    public void GameOver()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            //Restart the game
            countLives--;
            Invoke("Restart", restartDelay);
            livesCount.text = countLives.ToString("0");
        }
    }

    public void Restart()
    {
        if (countLives == 0)
        {
            score = score - 6; //earlier 12
            SceneManager.LoadScene("EndScene");
            countLives = 5;
        }
        else if(countLives>0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            if (SceneManager.GetActiveScene().buildIndex == 1 || SceneManager.GetActiveScene().buildIndex == 6)
            {
                score = 0;
            }

            if (SceneManager.GetActiveScene().buildIndex >= 1 && SceneManager.GetActiveScene().buildIndex <= 5 )
            {
                score = scoreCarry+6;
            }
       }
    }
}
