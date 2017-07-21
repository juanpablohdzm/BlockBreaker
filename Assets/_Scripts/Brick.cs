using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {
    
    
    private Ball ball;
    private int SpriteIndex;
    private bool IsStar;
    private LevelManager_CS LevelManager;

    public static int StarNumber = 0;
    public static int StarCountDestroy = 0;

   // public AudioClip Crack_sound;
    public int MaxHits;
    public Sprite[] Sprites;

   
    int TimesHits;

	// Use this for initialization
	void Start ()
    {
        IsStar = (this.tag == "Stars");
        if(IsStar)
        {
            StarNumber++;
        }
        SpriteIndex = -1;
        TimesHits=MaxHits;
        ball = GameObject.FindObjectOfType<Ball>();
        LevelManager = GameObject.FindObjectOfType<LevelManager_CS>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //AudioSource.PlayClipAtPoint(Crack_sound, transform.position);
        HitEvent(collision);
        
    }

    void HitEvent(Collision2D collision)
    {
        if (collision.gameObject == ball.gameObject)
        {
            if (TimesHits <= 0)
            {
                if (IsStar)
                {
                    StarNumber--;
                    StarCountDestroy++;
                    LevelManager.LastStarDestroy();
                }
                if(this.tag=="NewStar")
                    StarCountDestroy++;
                Destroy(gameObject);
            }
            else
            {
                TimesHits--;
                SpriteIndex++;
                LoadSprite();
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
    void LoadSprite()
    {
        if(Sprites.Length!=0)
        this.GetComponent<SpriteRenderer>().sprite = Sprites[SpriteIndex];
    }

    
    // Update is called once per frame
    void Update ()
    {
      
	}
}
