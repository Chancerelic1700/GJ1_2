using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Slider countdownSlider;
    public float gameTime;
    private bool stopCountdown;

    void Start()
    {
        stopCountdown = false;
        countdownSlider.maxValue = gameTime;
        countdownSlider.value = gameTime;
    }
    void Update()
    {
        float time = gameTime - Time.time;

        if ( time <= 0)
        {
            stopCountdown = true;
        }

        if ( stopCountdown == false)
        {
            countdownSlider.value = time;
        }    
    }
}
