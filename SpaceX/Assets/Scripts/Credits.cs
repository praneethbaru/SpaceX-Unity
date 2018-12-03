
using UnityEngine;
using UnityEngine.SceneManagement;
public class Credits : MonoBehaviour {
    
	public void RestartGame()
    {
        
        SceneManager.LoadScene("Level01");
        GameManager.score = 0;
        GameManager.countLives = 5;

        //GameManager.scoreCarry = 0; 
        //FindObjectOfType<GameManager>().score1.text=value.ToString();
    }

    public void goToMainMenu()
    {

        SceneManager.LoadScene("StartScene");
        GameManager.score = 0;
        GameManager.countLives = 5;

        //GameManager.scoreCarry = 0; 
        //FindObjectOfType<GameManager>().score1.text=value.ToString();
    }
}
