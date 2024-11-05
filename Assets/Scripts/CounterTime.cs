using System;
using System.Collections;
using UnityEngine;

public class CounterTime : MonoBehaviour
{
    private float _stepSecInTime = 0.5f;
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
                _timeFlowCoroutine = StartCoroutine(FlowingTime()); 
            }
            else
            {
                StopCoroutine(_timeFlowCoroutine); 
            }
        }
    }

    private IEnumerator FlowingTime()
    {
        var wait = new WaitForSeconds(_stepSecInTime);

        while (true)
        {
            Clicked?.Invoke();

            yield return wait;
        }
    }
}
