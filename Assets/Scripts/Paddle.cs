using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float mousePosInBlocks = Mathf.Clamp(Input.mousePosition.x / Screen.width * 16, 0, 16);

        this.transform.position = new Vector3(mousePosInBlocks, this.transform.position.y);
	}
}
