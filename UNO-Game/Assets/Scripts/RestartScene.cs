using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour {

    public Button button;
    void Update()
    {
        button.onClick.AddListener(OnClick);
    }
    void OnClick()
    {
        CardCompatabilityValues.StackColor = "Black";
        Scene loadedLevel = SceneManager.GetActiveScene();
        SceneManager.LoadScene(loadedLevel.buildIndex);
    }
}
