using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevatorButtons : MonoBehaviour
{
    public GameObject one, two, three;

    // Start is called before the first frame update
    void Start()
    {
        if(sceneControl.gamePhase == 1)
        {
            one.SetActive(true);
            two.SetActive(false);
            three.SetActive(false);
        }
        else if(sceneControl.gamePhase == 2)
        {
            one.SetActive(false);
            two.SetActive(true);
            three.SetActive(false);
        }
        else if(sceneControl.gamePhase == 4)
        {
            one.SetActive(false);
            two.SetActive(false);
            three.SetActive(true);
        }
        else if(sceneControl.gamePhase == 5)
        {
            one.SetActive(false);
            two.SetActive(true);
            three.SetActive(false);
        }

    }
}
