using UnityEngine;
using System.Collections;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;

    private void Start()
    {
        _text.text = "0";
        StartCoroutine(CountTime());
    }

    private IEnumerator CountTime(float delay = 0.5f, int startTime = 0)
    {
        var wait = new WaitForSeconds(delay);

        for (int i = startTime; i >= 0; i++)
        {
            ChangeCountOnDisplay(i);
            yield return wait;
        }
    }

    private void ChangeCountOnDisplay(int count)
    {
        _text.text = count.ToString("");
    }
}
