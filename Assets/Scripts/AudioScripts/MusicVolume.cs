using UnityEngine;

public class MusicVolume : MonoBehaviour
{
    [SerializeField] private AudioSource AudioSrc;

    private void Start()
    {
        AudioSrc.volume = Settings.MusicValume;
    }

    private void Update()
    {
        AudioSrc.volume = Settings.MusicValume;
    }
}
