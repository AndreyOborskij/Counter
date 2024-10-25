using TMPro;
using UnityEngine;

public class RendererTime : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _rendererCount;
    [SerializeField] private CounterTime _counterTime;

    private void OnEnable()
    {
        _counterTime.ActionChange += DisplayTime;
    }

    private void OnDisable()
    {
        _counterTime.ActionChange -= DisplayTime;
    }

    private void DisplayTime()
    {
        int time = _counterTime.Value;
        _rendererCount.text = time.ToString();
    }
}
