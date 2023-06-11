using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SuruklemeIsi : MonoBehaviour, IDragHandler, IEndDragHandler
{
    [SerializeField]
    private GameObject panel;

    private Vector3 firstPosition;
    void Start()
    {
        firstPosition = transform.position;
    }

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        
        transform.position = Input.mousePosition;
    }

    void IEndDragHandler.OnEndDrag(PointerEventData eventData)
    {
        float mesafe = Vector3.Distance(transform.position, panel.transform.position);

        if (mesafe <= 230)
            transform.SetParent(panel.transform);
        else
            transform.position = firstPosition;

    }

}
