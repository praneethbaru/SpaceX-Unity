
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuComponents : MonoBehaviour
{

    public void StartNormalModeGame()
    {
        GameManager.score = 0;
        SceneManager.LoadScene("Level01");
    }

    public void StartSurvivalModeGame()
    {
        GameManager.score = 0;
        SceneManager.LoadScene("Survival");
    }
}
