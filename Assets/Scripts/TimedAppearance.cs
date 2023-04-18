using UnityEngine;

sealed class TimedAppearance : MonoBehaviour
{
    [SerializeField] private GameObject _Object;

    private float _Time = 3f;

    private bool _Status;

    private void Start()
    {
        _Status = false;
    }

    private void Update()
    {
        _Time -= 1.00f * Time.deltaTime;

        _Status = _Time > 1f ? false : true;

        _Object.SetActive(_Status);
    }
}
