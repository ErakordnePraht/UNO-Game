using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_unpause : MonoBehaviour {

    public Transform canvas;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!canvas.gameObject.activeInHierarchy)
            {
                canvas.gameObject.SetActive(true);
                Time.timeScale = 0;
            }
            else
            {
                canvas.gameObject.SetActive(false);
                Time.timeScale = 1;
            }
        }
    }
}
