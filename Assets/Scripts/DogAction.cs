﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogAction : MonoBehaviour
{
    // Use this for initialization
    void Start() {
        // Set Rigidbody and all default parameters
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.freezeRotation = true;
        rigidBody.gravityScale = 0;
        rigidBody.angularDrag = 0;

        text = GameObject.FindWithTag("InfoToggle");

        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 20;
    }

    // Update is called once per frame
    void Update() {
        Debug.DrawRay(transform.position, rayDirection, Color.cyan);
        processMovement();
        processItemCollection();
    }

    void processMovement() { 

        //Resets the movement interval to allow immediate stopping for the player
        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow)
            || (!Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow))) {
            xMod = 0f;
        } 
        if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow)
            || (!Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow))) {
            yMod = 0f;
        }
        
        // Allow single direction input prioritizing horizontal over vertical
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            xMod = -speed;
            yMod = 0f;
            rayDirection = Vector2.left;
        } else if (Input.GetKeyDown(KeyCode.RightArrow)) {
            xMod = speed;
            yMod = 0f;
            rayDirection = Vector2.right;
        } else if (Input.GetKeyDown(KeyCode.UpArrow)) {
            yMod = speed;
            xMod = 0f;
            rayDirection = Vector2.up;
        } else if (Input.GetKeyDown(KeyCode.DownArrow))  {
            yMod = -speed;
            xMod = 0f;
            rayDirection = Vector2.down;
        }

        // Moves the rigid body based on things
        rigidBody.MovePosition(new Vector2(
            rigidBody.position.x + xMod,
            rigidBody.position.y + yMod));
    }

    //void processItemCollision() {
    //    RaycastHit2D hit = Physics2D.Raycast(rigidBody.position, rayDirection, rayDistance);
    //    if (hit) {
    //        //if (hit.collider.GetComponent<BodyPart>) {
    //        if (hit.collider.CompareTag("collection")) {
    //            text.SetActive(true);
    //        } else {
    //            text.SetActive(false);
    //        }
    //    } else {
    //        text.SetActive(false);
    //    }
    //}

    void processItemCollection()
    {
        RaycastHit2D hit = Physics2D.Raycast(rigidBody.position, rayDirection, rayDistance);
        if (hit) {
            //if (hit.collider.GetComponent<BodyPart>) {
            if (hit.collider.CompareTag("collection")) {
                text.SetActive(true);
            } else {
                text.SetActive(false);
            }

            if (Input.GetKeyUp(KeyCode.Space)) {

                hit.collider.gameObject.SetActive(false);

            }
        } else {
            text.SetActive(false);
        }

        
    }

    void OnCollisionEnter2D(Collision2D collider) {
        
    }

    Rigidbody2D rigidBody = null;
    Vector2 rayDirection = Vector2.down;
    public GameObject text;

    public float rayDistance = 0.6f;

    public float speed = 0.25f;
    float xMod = 0f;
    float yMod = 0f;
}
