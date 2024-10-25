using System;
using System.Collections;
using UnityEngine;

public class CounterTime : MonoBehaviour
{
    public event Action ActionChange;

    private int _value = 0;
    private int _count;

    public int Value => _value;

    private void Start()
    {
        StartCoroutine(TimeFlow());
    }

    private IEnumerator TimeFlow()
    {
        while (true)
        {
            _value += _count;

            ActionChange?.Invoke();

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
