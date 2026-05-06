using System;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public event Action OnClick;

    [SerializeField] private int _mouseButton = 0;

    private void Update()
    {
        if (Input.GetMouseButtonDown(_mouseButton))
        {
            OnClick?.Invoke();
        }
    }
}