using UnityEngine;

public class QuitButtonHandler : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("QUIT PRESSED!");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }
}