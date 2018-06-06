using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickUnpause : MonoBehaviour
{
    public GameObject canvas;
    public Button button;
    void Update()
    {
        button.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        canvas.SetActive(false);
        Time.timeScale = 1;
    }
}
