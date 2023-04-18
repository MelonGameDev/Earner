using UnityEngine;

public class ButtonAudio : MonoBehaviour
{
    [SerializeField] private AudioClip SoundOnClick;
    [SerializeField] private AudioSource _SoudonClic;

    [SerializeField] private AudioClip MusicOnRelease;
    [SerializeField] private AudioSource _MusicOnRelease;

    public void PlayOnClick()
    {
        _SoudonClic.PlayOneShot(SoundOnClick);
    }

    public void PlaybackWhenReleased()
    {
        _MusicOnRelease.PlayOneShot(MusicOnRelease);
    }
}
