using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushInElevator : MonoBehaviour
{
    public Animator anim;
    public GameObject player;

    public void push()
    {
        player.transform.position = new Vector3(21, player.transform.position.x);
        player.SetActive(false);
        StartCoroutine(pushIE());
    }

    public IEnumerator pushIE()
    {

        yield return new WaitForSeconds(3);
        anim.enabled = true;
    }
}
