using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameobjectDragAndDrop : MonoBehaviour {

    private bool isMouseDrag;
    private Vector3 screenPosition;
    private Vector3 offset;

    GameObject ReturnClickedObject(out RaycastHit hit)
    {
        GameObject target = null;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray.origin, ray.direction * 10, out hit))
        {
            target = hit.collider.gameObject;
        }
        return target;
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitinfo;
            GameObject target = ReturnClickedObject(out hitinfo);
            if (target != null)
            {
                isMouseDrag = true;
                Debug.Log("target position :" + target.transform.position);
                screenPosition = Camera.main.WorldToScreenPoint(target.transform.position);
                offset = target.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPosition.z));
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            isMouseDrag = false;
        }
        if (isMouseDrag)
        {
            Vector3 currentScreenSpace = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPosition.z);

            Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenSpace) + offset;
            transform.position = currentPosition;
        }
    }
}
