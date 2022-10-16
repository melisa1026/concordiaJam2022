using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 100;
    int currentHealth;
    public Transform attackPoint;
    public Rigidbody2D rb;
    float Direction;
    public float attackPush;
    public float attackUp   ;
    public Animator animator;
    public float distFromPlayer;
    public float fireRate;
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;   
    }

    // Update is called once per frame
    void Update()
    {

        float Distance = transform.position.x - attackPoint.position.x;
        //Enemy is on left of player
        if (Distance <= -distFromPlayer)
        {
            transform.position = new Vector3 (transform.position.x + 0.1f, transform.position.y, 0);
        }
        else if (Distance >= distFromPlayer)
        {
            transform.position = new Vector3(transform.position.x - 0.1f, transform.position.y, 0);
            
        }

        if (Mathf.Abs(Distance) < distFromPlayer + 0.5)
        {
            animator.SetTrigger("Throw");
            
        }
            
            
    }
    public void takeDamage(int Damage)
    {
        currentHealth -= Damage;
        Direction = attackPoint.position.x - transform.position.x;
        rb.AddForce(new Vector2(-Direction*attackPush, attackUp));
        if (currentHealth <= 0)
        {
            Die();

        }
    }
    void Die()
    {
        Debug.Log("Enemy Felled");
        Destroy(gameObject, 0.0f);
    }

        
}
