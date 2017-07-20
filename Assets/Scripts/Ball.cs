using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public Paddle paddle;
    private Vector3 PaddleToBallVector;
    private bool HasStarted=false;
	// Use this for initialization
	void Start () {
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
                GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
            }
        }
	}
}
