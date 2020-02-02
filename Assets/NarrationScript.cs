using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class NarrationScript : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject Option01;
    public GameObject Option02;
    public GameObject Option03;
    public GameObject Option04;
    public GameObject Option05;
    public GameObject Option06;
    public int OptionSelected;
    public string levelToLoad;
    [SerializeField]
    float screenDelay = 1.5f;


    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        // Code to execute after the delay
        SceneManager.LoadScene(levelToLoad, LoadSceneMode.Single);
    }


    public void optionSelected1()
    {
        TextBox.GetComponent<Text>().text = "Yummy, bones!";
        OptionSelected = 1;  
    }

    public void optionSelected2()
    {
        TextBox.GetComponent<Text>().text = "Isn't that where we first met?!";
        OptionSelected = 2;
    }

    public void optionSelected3()
    {
        TextBox.GetComponent<Text>().text = "I love walks!";
        OptionSelected = 3;
    }

    public void optionSelected4()
    {
        OptionSelected = 4;
    }

    public void optionSelected5()
    {
        OptionSelected = 5;
    }

    public void optionSelected6()
    {
        OptionSelected = 6;
        Application.Quit();
    }


    private void Start()
    {
           
    }

    void Update()
    {
        if (OptionSelected >= 1)
        {
            if (OptionSelected == 1) 
            {
                //Option01.SetActive(false);
                levelToLoad = "BaseMap";
                StartCoroutine(ExecuteAfterTime(screenDelay));
            } 
            else if(OptionSelected == 2)
            {
               //Option02.SetActive(false);
                levelToLoad = "BaseMapLeft";
                StartCoroutine(ExecuteAfterTime(screenDelay));
            }
            else if (OptionSelected == 3)
            {
                //Option03.SetActive(false);
                levelToLoad = "BaseMapRight";
                StartCoroutine(ExecuteAfterTime(screenDelay));
            }
            else if (OptionSelected == 4)
            {
               //Option04.SetActive(false);
                levelToLoad = "OpeningNarration";
                StartCoroutine(ExecuteAfterTime(screenDelay));
            }
            else if (OptionSelected == 5)
            {
                //Option05.SetActive(false);
                levelToLoad = "AboutUs";
                StartCoroutine(ExecuteAfterTime(screenDelay));
            }
            else if (OptionSelected == 6)
            {
                Option06.SetActive(false);
                StartCoroutine(ExecuteAfterTime(screenDelay));
            }
            Option01.SetActive(false); 
            Option02.SetActive(false); 
            Option03.SetActive(false); 
            Option04.SetActive(false); 
            Option05.SetActive(false); 
            Option06.SetActive(false);



        }

       

    }
}
