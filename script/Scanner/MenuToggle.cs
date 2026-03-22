using UnityEngine;

public class MenuToggle : MonoBehaviour
{
    public GameObject menuDropdown; // The panel you want to show/hide

    public void ToggleMenu()
    {
        // Toggle active state
        menuDropdown.SetActive(!menuDropdown.activeSelf);
    }
}
