using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedWalk : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        if ( Input.GetAxisRaw("Horizontal") ==  1)
        {
            transform.eulerAngles  = new Vector3 (0,0,0);
            GetComponent<Animator>().Play("WalkerAnimation");
        }
        else if ( Input.GetAxisRaw("Horizontal") ==  -1)
        {
            transform.eulerAngles  = new Vector3 (0,180,0);
            GetComponent<Animator>().Play("WalkerAnimation");
        }
        else 
        {
            GetComponent<Animator>().Play("StillMainCharacter");
        }

  
    }
}
