using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 100;
    int currentHealth;
    public Transform attackPoint;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;   
    }

    // Update is called once per frame

    public void takeDamage(int Damage)
    {
        currentHealth -= Damage;
        Debug.Log(attackPoint.position.x - transform.position.x);
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
