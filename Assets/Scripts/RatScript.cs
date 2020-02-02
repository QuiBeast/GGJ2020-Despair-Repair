using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DespairRepair;

public class RatScript : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        this.speed = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        processMovement();
    }

    void processMovement() {
        this.transform.position = new Vector2(transform.position.x + speed, transform.position.y);
    }

    public float speed;
}
