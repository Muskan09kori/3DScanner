using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LoginUIManager : MonoBehaviour
{
    [Header("Panels")]
    public GameObject loginPanel;
    public GameObject signupPanel;

    [Header("Signup Inputs")]
    public TMP_InputField nameInput;
    public TMP_InputField emailInput;
    public TMP_InputField passwordInput;
    public TMP_InputField confirmPasswordInput;

    void Update()
    {
        if (Application.platform == RuntimePlatform.Android && Input.GetKeyDown(KeyCode.Escape))
        {
            HandleBackSwipe();
        }
    }

    public void HandleBackSwipe()
    {
        if (signupPanel.activeSelf)
        {
            SwitchToLogin(); // Back to login from signup
        }
        else
        {
            Application.Quit(); // Exit app if on login screen
        }
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void SwitchToSignup()
    {
        loginPanel.SetActive(false);
        signupPanel.SetActive(true);
    }

    public void SwitchToLogin()
    {
        signupPanel.SetActive(false);
        loginPanel.SetActive(true);
    }

    public void HandleSignup()
    {
        string name = nameInput.text;
        string email = emailInput.text;
        string password = passwordInput.text;
        string confirmPassword = confirmPasswordInput.text;

        if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) ||
            string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
        {
            Debug.LogWarning("Please fill in all fields.");
            return;
        }

        if (password != confirmPassword)
        {
            Debug.LogWarning("Passwords do not match.");
            return;
        }

        Debug.Log("Account created successfully!");
        GoToMainMenu();
    }
}
