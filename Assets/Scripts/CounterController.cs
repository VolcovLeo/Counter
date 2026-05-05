using UnityEngine;
using TMPro;
using System.Collections;

public class CounterController : MonoBehaviour
{
    public TMP_Text CounterValue;

    private int counter = 0;
    private bool isCounting = false;
    private Coroutine routine;

    public void Start()
    {
        UpdateText();
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isCounting = !isCounting;

            if (isCounting)
            {
                routine = StartCoroutine(CounterRoutine());
            }
            else if (routine != null)
            {
                StopCoroutine(routine);
            }
        }
    }

    IEnumerator CounterRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            counter++;
            UpdateText();
        }
    }

    void UpdateText()
    {
        CounterValue.text = counter.ToString();
    }
}
