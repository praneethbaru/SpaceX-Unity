using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public  class GameManager : MonoBehaviour {

    bool gameHasEnded = false;
    public GameObject levelCompleteUI;
    public Transform player;
    public Text score1;
    public float restartDelay = 2f;
    public static float score;
    private static float scoreCarry = 0.0f;
    private int endScene = 3;


    public void Start()
    {
        //score = PlayerPrefs.GetFloat("score");
    }
    void Update()
    {
        //if not credit scene, keep adding
        if (SceneManager.GetActiveScene().buildIndex != endScene)
        {
            score = score + Time.deltaTime * 1.5f;
            score1.text = score.ToString("0");
        }

        //else don't add
        else
        {
            score1.text = score.ToString("0");
            //Scene - 6
         
        }
        
        if(SceneManager.GetActiveScene().buildIndex == 1)
        {
           
            score = score + Time.deltaTime * 1.5f;
            score1.text = score.ToString("0");
        }

    }
    public void OnDestroy()
    {
       // PlayerPrefs.SetFloat("score", score);
    }

    public void levelComplete()
    {
         scoreCarry = score;
        Debug.Log("LEVEL REACHED");
        levelCompleteUI.SetActive(true);
        
    }

    public void GameOver()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;

            //Restart the game
            Invoke("Restart", restartDelay);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            score = 0;
        }
        else
        {
            score = scoreCarry;
        }
    }

   
}
