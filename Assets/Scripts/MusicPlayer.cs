using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    private static MusicPlayer musicPlayerInstance = null;

	// Use this for initialization
	void Start () {
        if (musicPlayerInstance != null) {
            Destroy(gameObject);
            Debug.Log("Duplicate music player destroyed!");
        } else {
            musicPlayerInstance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
