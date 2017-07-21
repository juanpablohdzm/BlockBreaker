using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager_CS : MonoBehaviour {

    public Text text;
    public void Start()
    {
        
        Brick.StarCountDestroy = 0;

    }

    public void Update()
    {
        if(text != null)
        text.text = "Star Count: "+Brick.StarCountDestroy;
    }
    public void LoadLevel(string name)
    {
        Brick.StarNumber = 0;
        SceneManager.LoadScene(name,LoadSceneMode.Single);
    }

    public void QuitRequest()
    {
        Application.Quit();
    }

    public void LoadNextLevel()
    {
        Brick.StarNumber = 0;
        SceneManager.LoadScene(Application.loadedLevel+1); 
    }

    public void LastStarDestroy()
    {
        if(Brick.StarNumber==0)
        {
            
            LoadNextLevel();
        }
    }
}
