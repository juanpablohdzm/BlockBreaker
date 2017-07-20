using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {


    public int MaxHits;
    int TimesHits;

	// Use this for initialization
	void Start () {
        TimesHits = MaxHits;
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (TimesHits==0)
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

    // Update is called once per frame
    void Update () {
		
	}
}
