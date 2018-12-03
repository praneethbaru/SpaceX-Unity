
using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameManager gameManager;

    void OnTriggerEnter()
    {
        gameManager.LevelComplete();
        FindObjectOfType<GameManager>().score1.enabled = false;
    }
}
    