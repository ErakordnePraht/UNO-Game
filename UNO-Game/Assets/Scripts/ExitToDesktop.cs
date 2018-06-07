using UnityEngine;
using UnityEngine.UI;

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
