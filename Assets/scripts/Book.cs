using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{
    bool Direction;
    public Transform player;
    float PlayerPos;
    private void Start()
    {
        
    }
    public void flyingBook(bool side, Transform play) //right = false, left = true
    {
        Direction = side;
        player = play;
    }
    private void Update()
    {

        PlayerPos = player.position.x;
        if (Direction)
            transform.Translate(new Vector3(0.06f, 0f, 0f));
        else
            transform.Translate(new Vector3(-0.06f, 0f, 0f));

        if (transform.position.x >= PlayerPos-0.5 && transform.position.x <= PlayerPos + 0.5)
        {
            Destroy(gameObject); 
        }
    }
}
