using TMPro;
using UnityEngine;

public class RendererTime : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _rendererCount;
    [SerializeField] private CounterTime _counterTime;

    private int _time = 0;

    private void OnEnable()
    {
        _counterTime.Clicked += DisplayTime;
    }

    private void OnDisable()
    {
        _counterTime.Clicked -= DisplayTime;
    }

    private void DisplayTime()
    {
        _time++;
        _rendererCount.text = _time.ToString();
    }
}
