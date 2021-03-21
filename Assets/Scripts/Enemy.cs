using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;

    public void Damage(int amountOfDamage)
    {
        health = health - amountOfDamage;
        Debug.Log($"Current {health}");
        if (health < 0)
        {
            health = 0;
            Debug.LogWarning($"Current {health}");
            Destroy(gameObject);
        }
       
    }


}
