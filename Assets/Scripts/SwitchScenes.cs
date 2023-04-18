using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour
{
    public void Switch(int SceneNumber)
    {
        SceneManager.LoadScene(SceneNumber);
    }
}
