﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {


    //Object responsible for music of the entire game
    static MusicPlayer instance = null;

    private void Awake()
    {
        
    }

    // Use this for initialization
    void Start ()
    {
        
        if (instance != null)
            Destroy(gameObject);
        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}

   
}
