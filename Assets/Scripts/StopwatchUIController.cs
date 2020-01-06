using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StopwatchUIController : MonoBehaviour
{
    public TextMeshProUGUI timer;
    public GameObject stopButton;
    public GameObject startButton;
    public GameObject resetButton;
    public GameObject lapButton;
    // Start is called before the first frame update
    void Start()
    {
        timer.text = 0f.ToString("F2");
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeManager.Manager.StopwatchStarted) {
            UpdateTimer();
        }
    }

    private void UpdateTimer() {
        timer.text = TimeManager.Manager.StopwatchTime.ToString("F2");
    }

    public void OnStopClick() {
        stopButton.SetActive(false);
        startButton.SetActive(true);
        lapButton.SetActive(false);
        resetButton.SetActive(true);

        TimeManager.Manager.StopStopwatch();

        UpdateTimer();
    }

    public void OnStartClick() {
        stopButton.SetActive(true);
        startButton.SetActive(false);
        lapButton.SetActive(true);
        resetButton.SetActive(false);

        TimeManager.Manager.StartStopwatch();

        UpdateTimer();
    }

    public void OnResetClick() {

        TimeManager.Manager.ResetStopwatch();

        UpdateTimer();
    }

    public void OnLapClick() {
        TimeManager.Manager.LapStopwatch();
    }
}
