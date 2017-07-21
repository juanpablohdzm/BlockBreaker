using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour {
    public GameObject star;
    public Text text;

    public float MaxTime = 25f;
    private float last_star;
    private LevelManager_CS LevelManager;

    
	// Use this for initialization
	void Start ()
    {
        LevelManager = GameObject.FindObjectOfType<LevelManager_CS>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        float NewTime = MaxTime - Time.fixedTime;
        text.text = "Time: " + (int)NewTime;
        if (NewTime <= 0)
            LevelManager.LoadNextLevel();
        if(Time.fixedTime>last_star+1.5f)
        {
           int Case_Spawn= Random.Range(0, 3);
            switch(Case_Spawn)
            {
                case 0:
                    SpawnStar(2f);
                    break;
                case 1:
                    SpawnStar(6f);
                    break;
                case 2:
                    SpawnStar(10f);
                    break;
                case 3:
                    SpawnStar(14f);
                    break;
                default:
                    break;
            }
        }
    }

    void SpawnStar(float X_spawnpos)
    {
        
        GameObject new_star = Instantiate(star, new Vector3(X_spawnpos, 10f, 0), Quaternion.identity);
        new_star.AddComponent<Rigidbody2D>();
        new_star.GetComponent<Rigidbody2D>().gravityScale = 2.5f;
        new_star.tag="NewStar" ;
        last_star = Time.fixedTime;
    }
}
