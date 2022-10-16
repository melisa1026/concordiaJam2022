using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class talking : MonoBehaviour
{
    public GameObject textbox;
    public Text text;

    public void Start()
    {
        textbox.SetActive(false);
    }

    public void talk(string speech)
    {
        textbox.SetActive(true);
        text.text = speech;
    }

    public void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            textbox.SetActive(false);
        }
    }
}
