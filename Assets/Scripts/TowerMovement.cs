using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerMovement : MonoBehaviour
{
    public Transform currentTarget;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Enemy")
        {
          //  Debug.Log($"wykryto wroga{other.gameObject.name}");
            if (currentTarget == null)
            {

            currentTarget = other.gameObject.transform;
                GetComponent<TowerShooting>().enabled = true;
            }
            transform.LookAt(other.gameObject.transform);

        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.transform==currentTarget)
        {
            currentTarget = null;
            GetComponent<TowerShooting>().enabled = false; 
        }
    }
    private void Update()
    {
        if(currentTarget != null)
        {
            transform.LookAt(currentTarget);
        }
    }
}
