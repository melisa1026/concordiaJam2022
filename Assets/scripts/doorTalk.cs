using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class doorTalk : MonoBehaviour
{
    public Animator doorAnim;
    
        public GameObject textbox;
        public Text text;
        public GameObject door, doorShadow, annoyingDude, annoyingDudeButton, doorButton, teacher;
        public Sprite closedDoor;

    public void Start()
    {
        if(sceneControl.gamePhase == 1 || sceneControl.gamePhase == 4)
        {
            unanimateDoor();
        }

        else if(sceneControl.gamePhase == 7)
        {
            animateDoor();
            teacher.SetActive(false);
        }

        if(sceneControl.gamePhase == 1)
        {
            annoyingGuy();
        }
    }
    public void animateDoor()
    {
        doorAnim.enabled = true;
    }

    public void unanimateDoor()
    {
        doorAnim.enabled = false;
    }

    public void closeDoor()
    {
        door.GetComponent<SpriteRenderer>().sprite = closedDoor;
        unanimateDoor();
        doorShadow.SetActive(false);
        door.transform.Translate(-1,0.25f, 0);
    }

    public void screewDoor()
    {
        closeDoor();
        text.text = "now I'll have to screw the door // and things will be like they were before";
    }

    public void annoyingGuy()
    {
        annoyingDude.SetActive(true);
        annoyingDudeButton.SetActive(true);
        doorButton.SetActive(false);
    }

    public void pressDoor()
    {
        if(sceneControl.gamePhase == 4)
        {
            animateDoor();
        }
        else if(sceneControl.gamePhase == 7)
        {
            screewDoor();
             SceneManager.LoadScene("finale");
        }
    }
}
