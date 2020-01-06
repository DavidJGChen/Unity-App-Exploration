using UnityEngine;
public class TimeManager : MonoBehaviour
{
    private static TimeManager manager;
    public float Countdown = 60f * 60f * 2f;
    private float stopwatchTime;
    private bool stopwatchStarted;
    private Mode mode;
    private void Awake() {
        manager = this;
        stopwatchStarted = false; // TODO: Change this to support stopping and starting app
        mode = Mode.Timer;
    }
    private void Update() {
        switch (mode)
        {
            case Mode.Timer: {
                if (stopwatchStarted) {
                    stopwatchTime += Time.deltaTime;
                }
                break;
            }
            case Mode.Stopwatch:
                break;
            default:
                break;
        }
    }
    public static TimeManager Manager {
        get {
            if (manager == null) {
                manager = FindObjectOfType<TimeManager>();
            }
            return manager;
        }
    }

    public float StopwatchTime {
        get {
            return stopwatchTime;
        }
    }

    public bool StopwatchStarted {
        get {
            return stopwatchStarted;
        }
    }

    public void StartTimer() {

    }

    public void CancelTimer() {

    }

    public void PauseTimer() {

    }

    public void ResumeTimer() {

    }

    public void StartStopwatch() {
        stopwatchStarted = true;
    }

    public void ResetStopwatch() {
        if (stopwatchStarted) return;

        stopwatchTime = 0f;
    }

    public void StopStopwatch() {
        stopwatchStarted = false;
    }

    public void LapStopwatch() {
        print("Lap Stopwatch: " + stopwatchTime.ToString("F2"));
    }

    private enum Mode {
        Stopwatch,
        Timer,
    }
}
