﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : SceneController
{
    //public Transform player;

    // Use this for initialization
    public override void Start()
    {
        base.Start();

        if (prevScene == "BaseMapLeft" && currentScene == "BaseMap")
        {
            GameObject player = GameObject.FindWithTag("Player");
            player.transform.position = new Vector2(-8f, 0f);
        } else if(prevScene == "BaseMapRight" && currentScene == "BaseMap")
        {
            GameObject player = GameObject.FindWithTag("Player");
            player.transform.position = new Vector2(8f, 0f);
        }
    }
}
