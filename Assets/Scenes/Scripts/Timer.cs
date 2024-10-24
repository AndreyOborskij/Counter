using System.Collections;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
        
    private int _value = 0;
    private int _count;

    private void Start()
    {
        StartCoroutine(TimeFlow());
    }

    private IEnumerator TimeFlow()
    {
        while (true)
        {
            _value += _count;

            timerText.text = _value.ToString();

            yield return new WaitForSeconds(0.5f);
        }
    }

    public void Action(bool isWork)
    {
        if (isWork == true)
            _count = 1;
        else
            _count = 0;        
    }
}
