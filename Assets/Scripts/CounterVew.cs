using UnityEngine;
using TMPro;

public class CounterView : MonoBehaviour
{
    [SerializeField] private TMP_Text _counterValue;
    [SerializeField] private Counter _counter;
    [SerializeField] private InputHandler _input;

    private void OnEnable()
    {
        _counter.OnValueChanged += UpdateView;
        _input.OnClick += _counter.Toggle;
    }

    private void OnDisable()
    {
        _counter.OnValueChanged -= UpdateView;
        _input.OnClick -= _counter.Toggle;
    }

    private void UpdateView(int value)
    {
        _counterValue.text = value.ToString();
    }
}
