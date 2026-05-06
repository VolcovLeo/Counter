using System;
using UnityEngine;
using System.Collections;

public class Counter : MonoBehaviour
{
    public event Action<int> OnValueChanged;

    [SerializeField] private float _delay = 0.5f;

    private int _value;
    private bool _isCounting;
    private WaitForSeconds _wait;

    public int Value => _value;

    private void Awake()
    {
        _wait = new WaitForSeconds(_delay);
    }

    public void Toggle()
    {
        _isCounting = !_isCounting;

        if (_isCounting)
            StartCoroutine(Counting());
        else
            StopAllCoroutines();
    }

    private IEnumerator Counting()
    {
        while (_isCounting)
        {
            yield return _wait;

            _value++;
            OnValueChanged?.Invoke(_value);
        }
    }
}
