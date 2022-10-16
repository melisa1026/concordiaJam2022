using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{

    public float speed;
    private float position;
    //max and min positions
    public float max, min;
    public float startPositionX;

    // Start is called before the first frame update
    void Start()
    {
        position = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        //move when arrows are pressed (left & right)
        position += speed * Time.deltaTime * Input.GetAxisRaw("Horizontal");
        transform.position = new Vector3(position, transform.position.y, transform.position.z);


        //minimum and maximum
        if (transform.position.x > max)
            transform.position = new Vector3(max, transform.position.y, transform.position.z);
        else if (transform.position.x < min)
            transform.position = new Vector3(min, transform.position.y, transform.position.z);
    }
}
