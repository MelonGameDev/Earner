using UnityEngine;

public class EffectVolume : MonoBehaviour
{
    [SerializeField] private AudioSource AudioSrc;

    private void Start()
    {
        AudioSrc.volume = Settings.EffectsValume;
    }

    private void Update()
    {
        AudioSrc.volume = Settings.EffectsValume;
    }
}
