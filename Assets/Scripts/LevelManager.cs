using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public void LoadLevel(string levelName) {
        Debug.Log("Level load requested for:" + levelName);
        SceneManager.LoadScene(levelName);
    }

    public void QuitRequest() {
        Debug.Log("Quiting");
        Application.Quit();
    }
}
