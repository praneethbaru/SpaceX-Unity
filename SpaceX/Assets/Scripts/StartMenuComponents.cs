
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuComponents : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene("Level01");
    }
}
