
using UnityEngine;

public class LoseCollider : MonoBehaviour {

    public LevelManager_CS LevelManager;
    private void OnTriggerEnter2D(Collider2D trigger)
    {
        print("Trigger");
        LevelManager.LoadLevel("Lose");
    }

    
}
