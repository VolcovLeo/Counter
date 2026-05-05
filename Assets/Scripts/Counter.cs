using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter
{
    private int _value;

    public int Value => _value;

    public void Increase()
    {
        _value++;
    }
}
