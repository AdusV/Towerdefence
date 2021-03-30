using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    public Manager manager;

    private void Awake()
    {
        manager = GameObject.FindObjectOfType<Manager>();
        if (manager == null)
        {
            Debug.LogError("Blad");
        }
    }
    public void Damage(int amountOfDamage)
    {
        health = health - amountOfDamage;
        Debug.Log($"Current {health}");
        if (health < 0)
        {
            health = 0;
            Debug.LogWarning($"Current {health}");
            manager.AddEnemyToCounter();
            Destroy(gameObject);
        }
       
    }


}
