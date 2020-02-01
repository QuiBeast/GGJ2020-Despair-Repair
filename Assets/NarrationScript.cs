using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NarrationScript : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject Option01;
    public GameObject Option02;
    public GameObject Option03;
    public int OptionSelected;

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
    
    void Update()
    {
        if (OptionSelected >= 1)
        {
            Option01.SetActive(false);
            Option02.SetActive(false);
            Option03.SetActive(false);
        }
        
    }
}
