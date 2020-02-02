using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : SceneController
{
    //public Transform player;

    // Use this for initialization
    public override void Start()
    {
        gameObject.tag = "GameController";
        base.Start();
        Debug.Log("Previous Scene: " + prevScene);
        Debug.Log("Current Scene: " + currentScene);
        GameObject player = GameObject.FindWithTag("Player");

        if (prevScene == "BaseMapLeft" && currentScene == "BaseMap")
        {
            player.transform.position = new Vector2(-8f, 0f);
        } else if(prevScene == "BaseMapRight" && currentScene == "BaseMap")
        {
            player.transform.position = new Vector2(8f, 0f);
        } else if(prevScene == "BaseMapLeft" && currentScene == "BaseMapLeft2")
        {
            player.transform.position = new Vector2(7f, 6f);
        } else if(prevScene == "BaseMapLeft2" && currentScene == "BaseMapLeft")
        {
            player.transform.position = new Vector2(7f, -6f);
        } else if (prevScene == "BaseMap" && currentScene == "BaseMapLeft")
        {   
            player.transform.position = new Vector2(8f, 0f);
        } else if (prevScene == "BaseMap" && currentScene == "BaseMapRight")
        {
            player.transform.position = new Vector2(-8f, 0f);
        } else if (prevScene == "BaseMapLeft2" && currentScene == "BaseMapLeft3")
        {
            player.transform.position = new Vector2(-4f, 6f);
        } else if (prevScene == "BaseMapLeft3" && currentScene == "BaseMapLeft2")
        {
            player.transform.position = new Vector2(-4f, -6f);
        }

    }
}
