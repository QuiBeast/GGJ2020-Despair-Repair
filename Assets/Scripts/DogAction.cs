using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogAction : MonoBehaviour
{
    // Use this for initialization
    void Start() {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 10;
    }

    // Update is called once per frame
    void Update() {
        processMovement();
        processCollisionCorrection();
    }

    void processMovement() { 

        //Resets the movement interval to allow immediate stopping for the player
        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow)) {
            xMod = 0f;
        } else if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow)) {
            yMod = 0f;
        }
        
        // Allow single direction input prioritizing horizontal over vertical
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            xMod = -0.1f;
        } else if (Input.GetKeyDown(KeyCode.RightArrow)) {
            xMod = 0.1f;
        } else if (Input.GetKeyDown(KeyCode.UpArrow)) {
            yMod = 0.1f;
        } else if (Input.GetKeyDown(KeyCode.DownArrow))  {
            yMod = -0.1f;
        }

        transform.position = new Vector3(
            transform.position.x + xMod,
            transform.position.y + yMod,
            transform.position.z + zMod);
    }

    void processCollisionCorrection() {
        if(collision) {
            transform.position = new Vector3(
            transform.position.x - xMod,
            transform.position.y - yMod,
            transform.position.z - zMod);
        }
    }

    bool checkCollision (Collider2D collider) {
        if(collider.GetComponent<Collider>()) {
            Debug.Log("True");
            collision = true;
        } else {
            Debug.Log("False");
            collision = false;
        }
        return collision;
    }

    void OnCollisionEnter2D(Collision2D collider) {
        Debug.Log("True");
    }

    bool collision = false;

    float xMod = 0f;
    float yMod = 0f;
    float zMod = 0f;
}
