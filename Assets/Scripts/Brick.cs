using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

	public static int breakableCount = 0;

	public AudioClip crack;
    public Sprite[] hitSprites;

    private int timesHit;
    private LevelManager levelManager;
	private bool isBreakable;

	// Use this for initialization
	void Start () {
        timesHit = 0;
        levelManager = GameObject.FindObjectOfType<LevelManager>();
        isBreakable = (this.tag == "Breakable");
        if (isBreakable) {
	        breakableCount += 1;
	    }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionExit2D(Collision2D collision) {
    	AudioSource.PlayClipAtPoint(crack, transform.position);
    	if (isBreakable) {
	    	HandleHits();
	    }
    }

    void HandleHits() {
		int maxHits = hitSprites.Length + 1;
        timesHit += 1;

        if (timesHit >= maxHits) {
        	breakableCount -= 1;
        	levelManager.BrickDestroyed();
            Destroy(gameObject);
        } else {
        	LoadSprites();
        }
    }

    void LoadSprites() {
    	int spriteIndex = timesHit - 1;
    	if (hitSprites[spriteIndex]) {
	    	this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
	    }
    }
}
