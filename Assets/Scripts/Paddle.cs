using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	public bool autoPlay;
	private Ball ball;

	    // Use this for initialization
    void Start () {
        ball = GameObject.FindObjectOfType<Ball>();
	}
	
	// Update is called once per frame
	void Update () {
		if (autoPlay) {
			AutoPlay();
	    } else {
	        MoveWithMouse();	    	
	    }
	}

	void AutoPlay() {
		this.transform.position = new Vector3(ball.transform.position.x, this.transform.position.y);
	}

	void MoveWithMouse() {
		float mousePosInBlocks = Mathf.Clamp(Input.mousePosition.x / Screen.width * 16, 0, 16);

        this.transform.position = new Vector3(mousePosInBlocks, this.transform.position.y);
	}
}
