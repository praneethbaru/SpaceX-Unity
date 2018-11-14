
using UnityEngine;
using UnityEngine.SceneManagement;
public class Credits : MonoBehaviour {
    
	public void RestartGame()
    {
        
        SceneManager.LoadScene("Level01");
        GameManager.score = 0;
        //FindObjectOfType<GameManager>().score1.text=value.ToString();
    }
}
