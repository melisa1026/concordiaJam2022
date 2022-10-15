using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    //maximum and minimum camera position
    public float max, min;
    //attatch character to script
    public GameObject character;

    private float HalfCameraWidth;

    // Start is called before the first frame update
    void Start()
    {

        HalfCameraWidth = GetComponent<Camera>().orthographicSize * GetComponent<Camera>().aspect;

    }

    // Update is called once per frame
    void Update()
    {

        //camera follows character

        transform.position = new Vector3(character.transform.position.x, transform.position.y, transform.position.z);

        //camera stops at max and min if character is too far

        if (character.transform.position.x > max)
            transform.position = new Vector3(max, transform.position.y, transform.position.z);
        else if (character.transform.position.x < min)
            transform.position = new Vector3(min, transform.position.y, transform.position.z);

    }
}