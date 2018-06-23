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

    public void NextLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void BrickDestroyed() {
        if (Brick.breakableCount <= 0) {
            NextLevel();
        }
    }
}
