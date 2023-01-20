using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monaLosaRoom : MonoBehaviour
{

    public GameObject monaLisa;
    public GameObject elevatorButton;
    public GameObject elevator;
    private bool isOpening; // used so that elevator opening is only marked once per time th mouse goes over it
    private Vector3 mousePos;

    // when the mona lisa is pressed, it disappears and the elevator button works properly
    public void clickMonaLisa()
    {
        monaLisa.SetActive(false);
        elevatorButton.SetActive(true);
    }

    //make elevator open when the mouse is hovering
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if(mousePos.x > 2.95f && mousePos.y > -1.42f && mousePos.x < 7.43f && mousePos.y < 4.03f)
        {
            if(!isOpening)
            {
                elevator.GetComponent<Animator>().Play("elevatorOpening");
                isOpening = true;
            }
        }
        else
        {
            if(isOpening)
            {
                elevator.GetComponent<Animator>().Play("elevatorClosing");
                isOpening = false;
            }
        }
    }
}
