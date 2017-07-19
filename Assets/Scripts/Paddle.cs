using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    float MousePosInBlocks;
    public float MaxRange_X = 15.5f;
    public float MinRange_X = 0.5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 PaddlePos = new Vector3(MousePosInBlocks, this.transform.position.y, 0);
        MousePosInBlocks = Input.mousePosition.x/Screen.width * 16 ;
        PaddlePos.x=  Mathf.Clamp(MousePosInBlocks, MinRange_X, MaxRange_X);
        this.transform.SetPositionAndRotation(PaddlePos,Quaternion.identity);
    }
}
