using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ThrowBook : MonoBehaviour
{
    public GameObject book;
    public Transform player;
    float distance;

    // Start is called before the first frame update
    void onBookThrow()
    {
        distance = player.position.x - transform.position.x;
        GameObject NewBook =Instantiate(book, transform.position, transform.rotation);
        if (distance > 0)
            NewBook.GetComponent<Book>().flyingBook(true, player);
        else
        {
            NewBook.GetComponent<Book>().flyingBook(false, player);
        }


    }

}
