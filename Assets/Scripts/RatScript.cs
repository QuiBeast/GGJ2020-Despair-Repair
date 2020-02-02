using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatScript : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        processMovement();
    }

    void processMovement() {
        this.transform.position = new Vector2(transform.position.x + 0.1f, transform.position.y);
    }

}
