using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public int amountOfDamage;
    private void Start()
    {
        Destroy(gameObject, 2);
    }
    private void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("NIestety trafilem");
            other.GetComponent<Enemy>().Damage(amountOfDamage);
            Destroy(gameObject);
        }
    }
}
