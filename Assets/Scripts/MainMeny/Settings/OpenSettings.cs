using UnityEngine;

public class OpenSettings : MonoBehaviour
{
    [SerializeField] private GameObject SettingsWindow;

    private bool Status = false;

    public void OpenSettingsWindow()
    {
        Status = !Status;
        SettingsWindow.SetActive(Status);
    }
}
