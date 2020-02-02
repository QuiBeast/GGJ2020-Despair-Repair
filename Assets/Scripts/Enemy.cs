using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DespairRepair;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.collider.CompareTag("Player")) {
            BodyPartInventoryManager manager = GameObject.FindObjectOfType<BodyPartInventoryManager>();
            manager.RemoveLastBodyPart();
            Debug.Log("Destroyed");
        }

        Debug.Log("Dead");
        Destroy(this.gameObject);
    }
}
