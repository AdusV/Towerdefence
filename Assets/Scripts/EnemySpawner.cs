using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int interval;

    private void Start()
    {
        InvokeRepeating("SpawnEnemy", 1, interval);
    }
    private void SpawnEnemy()
    {
          Instantiate(enemyPrefab, new Vector3(7.5f, 0, 0), Quaternion.identity)    ;
    }
}
