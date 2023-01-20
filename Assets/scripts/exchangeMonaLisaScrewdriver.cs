using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exchangeMonaLisaScrewdriver : MonoBehaviour
{
    public GameObject normalButton, screwdriverButton, continueButton;

    public void Start()
    {
        if(sceneControl.gamePhase != 6)
        {
            screwdriverButton.SetActive(false);
        }
        else
        {
            normalButton.SetActive(false);
            continueButton.SetActive(false);
        }
    }

    public void exchange()
    {
        continueButton.SetActive(true);
    }

}
