﻿using UnityEngine;
using UnityEngine.SceneManagement;
public class FadeInAndOut : MonoBehaviour
{
    //public Animator animator;

    private int levelToLoad;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //FadeToLevel(2);
            FadeToNextLevel();
        }
    }


    public void FadeToNextLevel()
    {
        FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void FadeToLevel (int levelIndex) 
    {
        SceneManager.LoadScene(levelIndex);
        //animator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
