using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {

   // PlayerMovement PlayerMovement;
    public void LoadNextLevel()
    {
       // PlayerMovement.enabled = true;
       if(SceneManager.GetActiveScene().buildIndex != 5)
       {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       }

        else
        {
            SceneManager.LoadScene("EndScene");
        }
        
    }
}
