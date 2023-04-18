using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    [SerializeField] private Text Music;
    [SerializeField] private Text Effects;

    static public float MusicValume = 1f;
    static public float EffectsValume = 1f;

    public void _Music()
    {
        if (MusicValume == 1f)
        {
            MusicValume = 0f;
            Music.text = "Off";
        }
        else
        {
            MusicValume = 1f;
            Music.text = "On";
        }
    }

    public void _Effect()
    {
        if (EffectsValume == 1f)
        {
            EffectsValume = 0f;
            Effects.text = "Off";
        }
        else
        {
            EffectsValume = 1f;
            Effects.text = "On";
        }
    }
}
