using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject panelStart;
    private void Start()
    {
        panelStart.SetActive(true);
        Time.timeScale = 0;
    }

    public void Play()
    {
        panelStart.SetActive(false);
        Time.timeScale = 1;
    }
}
