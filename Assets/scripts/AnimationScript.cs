using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{

    public GameObject blackScreen;

    public void appearEndMessage()
    {
        blackScreen.SetActive(true);
        GetComponent<Animator>().enabled = false;
    }
}
