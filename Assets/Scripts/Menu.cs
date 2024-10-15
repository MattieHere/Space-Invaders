using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public Button switchButton;
    public string targetSceneName; // The name of the scene to switch to

    void Start()
    {
        // Attach a method to the button's click event
        switchButton.onClick.AddListener(SwitchScene);
    }

    void SwitchScene()
    {
        // Load the target scene
        SceneManager.LoadScene(targetSceneName);
    }
}
