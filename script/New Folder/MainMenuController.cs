using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{
    public void OnExploreButtonClicked()
    {
        Debug.Log("✅ Explore button clicked - Loading ScannerScene...");
        SceneManager.LoadScene("ScannerScene");
    }

    public void OnExitButtonClicked()
    {
        Debug.Log("❌ Exit button clicked - Quitting application...");

        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                    Application.Quit();
        #endif
    }
}
