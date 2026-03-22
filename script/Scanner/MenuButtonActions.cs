using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuButtonActions : MonoBehaviour
{
    public GameObject menuDropdown; // Drag the dropdown panel here
    private bool isMenuOpen = false;

    public float animationDuration = 0.25f;

    public void ToggleMenu()
    {
        if (!isMenuOpen)
        {
            menuDropdown.SetActive(true);
            StartCoroutine(ScaleUp());
        }
        else
        {
            StartCoroutine(ScaleDown());
        }

        isMenuOpen = !isMenuOpen;
    }

    private IEnumerator ScaleUp()
    {
        float elapsed = 0f;
        Vector3 start = Vector3.zero;
        Vector3 end = Vector3.one;

        while (elapsed < animationDuration)
        {
            menuDropdown.transform.localScale = Vector3.Lerp(start, end, elapsed / animationDuration);
            elapsed += Time.deltaTime;
            yield return null;
        }

        menuDropdown.transform.localScale = end;
    }

    private IEnumerator ScaleDown()
    {
        float elapsed = 0f;
        Vector3 start = menuDropdown.transform.localScale;
        Vector3 end = Vector3.zero;

        while (elapsed < animationDuration)
        {
            menuDropdown.transform.localScale = Vector3.Lerp(start, end, elapsed / animationDuration);
            elapsed += Time.deltaTime;
            yield return null;
        }

        menuDropdown.transform.localScale = end;
        menuDropdown.SetActive(false);
    }

    public void ExitApp()
    {
        Application.Quit();
    }

    public void GoBack()
    {
        SceneManager.LoadScene("MainMenu"); // Change if needed
    }
}
