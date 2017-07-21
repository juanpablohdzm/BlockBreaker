using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    private Paddle paddle;
    private Vector3 PaddleToBallVector;
    private bool HasStarted=false;
	// Use this for initialization
	void Start () {
        paddle = GameObject.FindObjectOfType<Paddle>();
        PaddleToBallVector = this.transform.position-paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (!HasStarted)
        {
            this.transform.position = paddle.transform.position + PaddleToBallVector;

            if (Input.GetMouseButtonDown(0))
            {
                HasStarted = true;
                GetComponent<Rigidbody2D>().velocity = new Vector2(1f, 10f);
            }
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<AudioSource>().Play();
    }
}
