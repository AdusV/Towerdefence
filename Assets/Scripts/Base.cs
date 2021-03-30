using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    public Manager manager;
    private void Start()
    {
        manager.ourBase = transform;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("Koniec gry");
            Time.timeScale = 0;
            manager.GameOver();
        }
    }
}
