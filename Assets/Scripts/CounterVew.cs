using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CounterView : MonoBehaviour
{
    [SerializeField] private TMP_Text _counterValue;

    private Counter _counter;
    private bool _isCounting;
    private Coroutine _countingRoutine;

    private void Start()
    {
        _counter = new Counter();
        UpdateView();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ToggleCounting();
        }
    }

    private void ToggleCounting()
    {
        _isCounting = !_isCounting;

        if (_isCounting)
        {
            _countingRoutine = StartCoroutine(Counting());
        }
        else
        {
            if (_countingRoutine != null)
            {
                StopCoroutine(_countingRoutine);
                _countingRoutine = null;
            }
        }
    }

    private IEnumerator Counting()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);

            _counter.Increase();
            UpdateView();
        }
    }

    private void UpdateView()
    {
        _counterValue.text = _counter.Value.ToString();
    }
}
