using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {

    public LevelManager levelManager;

    private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log("Trigger");
        levelManager.LoadLevel("Lose");
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        Debug.Log("Collision");
        levelManager.LoadLevel("Lose");
    }
}
