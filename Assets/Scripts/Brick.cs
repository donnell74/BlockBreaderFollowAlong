using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    public int maxHits;
    private int timesHit;

	// Use this for initialization
	void Start () {
        timesHit = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision) {
        timesHit += 1;
        Debug.Log("Times hit: " + timesHit);

        if (timesHit >= maxHits) {
            Destroy(this);
        }
    }
}
