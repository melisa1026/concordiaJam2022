using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class talking : MonoBehaviour
{
    public GameObject textbox, twoPersonTextbox1, twoPersonTextbox2;
    public Text text, twoPersonText1, twoPersonText2;
    public string twoPersonLine1, twoPersonLine2;
    public string startText; // character says this when entering a scene (when necessary)

    public void Start()
    {
        textbox.SetActive(false);

        if(startText != null && startText.Length > 0 && sceneControl.gamePhase > 0)
        {
            talk(startText);
        }
    }

    // when button to talk to someone is pressed, this method makes the speech pop up
    public void talk(string speech)
    {
        speech = speech.Replace("\\n", "\n");
        speech = speech.Replace("\\t", "\t");

        textbox.SetActive(true);
        text.text = speech;
    }

    public void setTwoPersonLine1(string speech)
    {
        
        speech = speech.Replace("\\n", "\n");
        speech = speech.Replace("\\t", "\t");

        twoPersonLine1 = speech;
    }

    public void setTwoPersonLine2(string speech)
    {
        
        speech = speech.Replace("\\n", "\n");
        speech = speech.Replace("\\t", "\t");

        twoPersonLine2 = speech;
    }

    // when button to talk to someone that involved two people talking, this method makes two speech boxes pop up
    public void twoPersonConversation()
    {
        
        twoPersonTextbox1.SetActive(true);
        twoPersonText1.text = twoPersonLine1;

        twoPersonTextbox2.SetActive(true);
        twoPersonText2.text = twoPersonLine2;
    }

    // when the player taps the screen, any open textbox will disappear
    public void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            textbox.SetActive(false);

            if(twoPersonTextbox1 != null && twoPersonTextbox2 != null) 
            {
                twoPersonTextbox1.SetActive(false);
                twoPersonTextbox2.SetActive(false);
            }
        }
    }

}
