using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
    float timeLeft;
    Text timerText;
    bool timerOn;
    string extraZero;

	// Use this for initialization
	void Start () {
        timeLeft = 60;
        timerText = GameObject.Find("TimerText").GetComponent<Text>();
        timerOn = false;
        extraZero = "";
	}

    // Update is called once per frame
    void Update()
    {
        extraZero = timeLeft < 10 ? "0" : "";
        if (timerOn)
        {
            timeLeft -= Time.deltaTime;
            timerText.text = "Time Remaining: " + Mathf.Floor(timeLeft / 60) + ":" + extraZero + Mathf.Floor(((timeLeft / 60) - Mathf.Floor(timeLeft / 60)) * 60);
            if (timeLeft <= 0)
            {
                timerText.text = "Time Remaining: 0:00";
                SceneManager.LoadScene("LateEndGame");
            }
        }
    }

    public void turnOnTimer()
    {
        timerOn = true;
    }

    public void turnOffTimer()
    {
        timerText.text = "";
        timerOn = false;
    }
}
