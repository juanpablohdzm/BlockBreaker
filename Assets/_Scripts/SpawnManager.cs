using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {
    public GameObject star;
    private float last_star;
    
	// Use this for initialization
	void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {
        
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
