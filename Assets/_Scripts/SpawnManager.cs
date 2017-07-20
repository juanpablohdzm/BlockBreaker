using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {
    public GameObject star;
    private float last_star;
    
	// Use this for initialization
	void Start ()
    {
        float X_spawnpos = Random.Range(0, 16);
        last_star = Time.fixedTime;
        GameObject new_star = Instantiate(star, new Vector3(X_spawnpos,10f, 0), Quaternion.identity);
        new_star.AddComponent<Rigidbody2D>();
        new_star.AddComponent<BoxCollider2D>();

    }
	
	// Update is called once per frame
	void Update ()
    {
        
        if(Time.fixedTime>last_star+3f)
        {
            float X_spawnpos = Random.Range(0, 16);
            GameObject new_star = Instantiate(star, new Vector3(X_spawnpos, 10f, 0), Quaternion.identity);
            new_star.AddComponent<Rigidbody2D>();
            new_star.AddComponent<BoxCollider2D>();
            last_star = Time.fixedTime;
        }
    }
}
