using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TowerBase : MonoBehaviour, IPointerEnterHandler,IPointerExitHandler, IPointerClickHandler
{
    public GameObject towerGhost;
    public GameObject towerPrefab;
    Manager manager;
    public void OnPointerClick(PointerEventData eventData)
    {
        Instantiate(towerPrefab, transform.position, transform.rotation);
        towerGhost.SetActive(false);
        GetComponent<MeshCollider>().enabled = false;
        Time.timeScale = 1;
        manager.panelPlaceTurret.SetActive(false);
        manager.turrentManager.UnregisterTurret(this);
        manager.turrentManager.DeactivateAllBases();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        towerGhost.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        towerGhost.SetActive(false);
    }
    private void Start()
    {
        manager = GameObject.FindObjectOfType<Manager>();
        Debug.LogError("Bladd");
        manager.turrentManager.RegisterTurret(this);
    }
}
