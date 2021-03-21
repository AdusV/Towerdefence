using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TowerBase : MonoBehaviour, IPointerEnterHandler,IPointerExitHandler, IPointerClickHandler
{
    public GameObject towerGhost;
    public GameObject towerPrefab;
    public void OnPointerClick(PointerEventData eventData)
    {
        Instantiate(towerPrefab, transform.position, transform.rotation);
        towerGhost.SetActive(false);
        GetComponent<MeshCollider>().enabled = false; 
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        towerGhost.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        towerGhost.SetActive(false);
    }
}
