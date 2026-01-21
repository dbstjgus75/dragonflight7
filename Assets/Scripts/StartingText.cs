using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class StartingText : MonoBehaviour
{
    private Text startText;

    private Coroutine blinkCoroutine;

    void Start()
    {
        startText = GetComponent<Text>();

        blinkCoroutine = StartCoroutine(BlinkText(0.5f));

        StartCoroutine(CountdownAndStopBlink(3));

    }

    //텍스트를 주기적으로 켜고 끄는 코루틴
    IEnumerator BlinkText(float interval)
    {
        while (true)
        {
            if (startText != null)
            {
                startText.enabled = !startText.enabled;
                
            }
            yield return new WaitForSeconds(interval);
        }
    }

    //카운트다운을 표시하고 끝나면 깜박임 코루틴을 중단
    IEnumerator CountdownAndStopBlink(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            startText.text = "CountDown : " + i;

            yield return new WaitForSeconds(1f);
        }

        startText.text = "Go!";
        yield return new WaitForSeconds(1f);

        StopCoroutine(blinkCoroutine);
        startText.enabled = false;
    }
   
}
