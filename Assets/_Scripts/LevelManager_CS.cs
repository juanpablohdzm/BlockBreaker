using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager_CS : MonoBehaviour {

   
	public void LoadLevel(string name)
    {
        SceneManager.LoadScene(name,LoadSceneMode.Single);
    }

    public void QuitRequest()
    {
        Application.Quit();
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(Application.loadedLevel+1); 
    }
}
