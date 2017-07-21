using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    float MousePosInBlocks;
    public float MaxRange_X = 15.5f;
    public float MinRange_X = 0.5f;
    public bool autoplay = false;

    private Ball ball;
	// Use this for initialization
	void Start () {
        ball = GameObject.FindObjectOfType<Ball>();
	}
	
	// Update is called once per frame
	void Update () {
        if (!autoplay)
            MoveWithMouse();
        else
            AutoPlay();

        if (Input.GetKeyDown(KeyCode.X))
            autoplay = !autoplay;

    }

    void MoveWithMouse()
    {
        Vector3 PaddlePos = new Vector3(.5f, this.transform.position.y, 0);
        MousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
        PaddlePos.x = Mathf.Clamp(MousePosInBlocks, MinRange_X, MaxRange_X);
        this.transform.SetPositionAndRotation(PaddlePos, Quaternion.identity);
    }

    void AutoPlay()
    {
        Vector3 PaddlePos = new Vector3(.5f, this.transform.position.y, 0);
        float BallPos=ball.transform.position.x;
        PaddlePos.x = Mathf.Clamp(BallPos, MinRange_X, MaxRange_X);
        this.transform.SetPositionAndRotation(PaddlePos, Quaternion.identity);
    }
}
