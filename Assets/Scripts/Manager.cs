using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject panelStart;
    public GameObject panelGameOver;
    public GameObject panelWin;
    public GameObject panelPlaceTurret;
    public TurrentManager turrentManager;
    public Transform ourBase;

    int currentWave = 0;
    public int[] waves;
    int counter;
    
    private void Start()
    {
        panelGameOver.SetActive(false);
        panelStart.SetActive(true);
        panelWin.SetActive(false);
        panelPlaceTurret.SetActive(false);
        turrentManager.DeactivateAllBases();    
        Time.timeScale = 0;
    }

    public void Play()
    {
        panelStart.SetActive(false);
        panelPlaceTurret.SetActive(true);
        turrentManager.ActivateAllBases();
        //Time.timeScale = 1;
    }
    public void GameOver()
    {
        panelGameOver.SetActive(true);
        Time.timeScale = 0;
    }
    public void PlayAgain()
    {
        panelGameOver.SetActive(false);
        DestroyAllEnemies();
        Time.timeScale = 1;


    }
    public void WaveFinished()
    {
        panelWin.SetActive(true);
        Time.timeScale = 0;
    }
    public void PlayNextWave()
    {
        panelWin.SetActive(false);
        DestroyAllEnemies();
        counter = 0;
        currentWave++;
        panelPlaceTurret.SetActive(true);
        turrentManager.ActivateAllBases();
        //Time.timeScale = 1;
    }
    void DestroyAllEnemies()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        if(enemies.Length == 0)
        {
            return;
        }
        for (int i = 0; i < enemies.Length; i++)
        {
            Destroy(enemies[i]);
        }
    }
    public void AddEnemyToCounter()
    {
        counter++;
        IsWaveFinished();
    }

    bool IsWaveFinished()
    {
        if (counter >= waves[currentWave])
        {
            Debug.Log("fala zakocznoa");
            WaveFinished();
            return true;
        }
        return false;
    }
}
