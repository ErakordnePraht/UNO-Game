using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Closes the app, after the user has clicked on the "Exit to desktop" button.
/// </summary>
public class ExitToDesktop : MonoBehaviour
{
    public Button button;
    void Update()
    {
        button.onClick.AddListener(OnClick);
    }
    void OnClick()
    {
        Application.Quit();
    }

}
