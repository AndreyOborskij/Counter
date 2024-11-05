using System;
using System.Collections;
using UnityEngine;

public class CounterTime : MonoBehaviour
{
    private float _stepInTime = 0.5f;
    private bool _isAction = false;
    private Coroutine _timeFlowCoroutine;

    public event Action Clicked;

    private void Update()
    {
        Calculate();        
    }

    public void Calculate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _isAction = !_isAction;

            if (_isAction == true) 
            {
                _timeFlowCoroutine = StartCoroutine(TimeFlow()); 
            }
            else
            {
                StopCoroutine(_timeFlowCoroutine); 
            }
        }
    }

    private IEnumerator TimeFlow()
    {
        var wait = new WaitForSeconds(_stepInTime);

        while (true)
        {
            Clicked?.Invoke();

            yield return wait;
        }
    }
}
