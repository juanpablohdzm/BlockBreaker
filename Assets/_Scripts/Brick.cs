using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    private Ball ball;
    public int MaxHits;
    private LevelManager_CS LevelManager;
    int TimesHits;

	// Use this for initialization
	void Start () {
        TimesHits = MaxHits;
        ball = GameObject.FindObjectOfType<Ball>();
        LevelManager = GameObject.FindObjectOfType<LevelManager_CS>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == ball.gameObject)
        {
            if (TimesHits <= 0)
                Destroy(gameObject);
            else
            {
                TimesHits--;
                switch (TimesHits)
                {
                    case 2:
                        GetComponent<SpriteRenderer>().color = Color.green;
                        break;
                    case 1:
                        GetComponent<SpriteRenderer>().color = Color.yellow;
                        break;
                    case 0:
                        GetComponent<SpriteRenderer>().color = Color.red;
                        break;

                    default:
                        break;
                }

            }
        }
        else
        {
            gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
