using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public static bool isPaused = false;
    public GameObject pauseMenuUI;
    public GameObject mainCamera;
    AudioSource audioSource;


    void Start()
    {
        audioSource = mainCamera.GetComponent<AudioSource>();
    }


	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
        {
            if(isPaused)
            {
                
                Resume();
            }

            else
            {
                Pause();
            }
        }
	}

    public void Resume()
    {
        audioSource.volume = 1.0f;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        FindObjectOfType<GameManager>().score1.enabled = true   ;
    }

    void Pause()
    {
        audioSource.volume = 0.1f;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        FindObjectOfType<GameManager>().score1.enabled = false;

    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("StartScene");
        isPaused = false;
        Resume();
    }

    public void QuitGame()
    {
        Resume();
        isPaused = false;
        Debug.Log("QUITTING THE GAME");
        SceneManager.LoadScene("StartScene");
        Application.Quit();
        
    }
}
