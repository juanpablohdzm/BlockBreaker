
using UnityEngine;

public class LoseCollider : MonoBehaviour {

  
    private Ball ball;
    private LevelManager_CS LevelManager;
    private void Start()
    {
        ball = GameObject.FindObjectOfType<Ball>();
        LevelManager = GameObject.FindObjectOfType<LevelManager_CS>();
    }
    private void OnTriggerEnter2D(Collider2D trigger)
    {

        if (trigger.gameObject == ball.gameObject)
            LevelManager.LoadLevel("Lose");
        else
            Destroy(trigger.gameObject);
    }

    
}
