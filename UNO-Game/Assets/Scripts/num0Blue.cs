using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class num0Blue : MonoBehaviour, IDragHandler /*IEndDragHandler*/
{
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    //public void OnEndDrag(PointerEventData eventData)
    //{
    //    transform.localPosition = Vector3.zero;
    //}

    //private bool dragging = false;
    //private float distance;

    //private void OnMouseDown()
    //{
    //    distance = Vector3.Distance(transform.position, Camera.main.transform.position);
    //    dragging = true;
    //}

    //private void OnMouseUp()
    //{
    //    dragging = false;
    //}

    //private void Update()
    //{
    //    if (dragging)
    //    {
    //        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //        Vector3 rayPoint = ray.GetPoint(distance);
    //        transform.position = rayPoint;
    //    }
    //}
}
