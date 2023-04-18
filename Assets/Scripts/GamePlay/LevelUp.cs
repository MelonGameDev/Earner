using UnityEngine;
using UnityEngine.UI;

sealed class LevelUp : MonoBehaviour
{
    [SerializeField] private Image ProgressBar;
    [SerializeField] private Text LevelIndex;

    private int Level = 0;
    private float fill = 0.05f;

    private void Start()
    {
        ProgressBar.fillAmount = 0f;
    }

    private void Update()
    {
        LevelIndex.text = Level.ToString() + " lvl";

        UpdateLevel();
    }

    private void UpdateLevel()
    {
        if (ProgressBar.fillAmount >= 1f & Level < 10)
        {
            Level++;
            fill = fill / 2;
            ProgressBar.fillAmount = 0;
        }
    }

    public void _ProgressBar()
    {
        if (fill < 1 & Level <= 10)
            ProgressBar.fillAmount += fill;
    }
}
