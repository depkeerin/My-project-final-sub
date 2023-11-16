using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public Text timerText;
    private float countdownTime = 30f;

    void Start()
    {
        UpdateTimerText();
    }

    void Update()
    {
        countdownTime -= Time.deltaTime;

        if (countdownTime <= 0f)
        {
            countdownTime = 0f;
        }

        UpdateTimerText();
    }

    void UpdateTimerText()
    {
        string formattedTime = countdownTime.ToString("F1");

        timerText.text = "Time Remaining" +
            ": " + formattedTime;
    }
}
