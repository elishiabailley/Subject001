using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    //Elishia Bailey, BAI16003710

    
    public float timeLeft = 50.0f; //Overall time
    public Text timerText; //displays time left

    void Update()
    {
        timeLeft -= Time.deltaTime; //timer continously decreases by 1

        //once time = 0, scene restarts
        if (timeLeft < 0)
        {
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        }

        //changes timer text
        timerText.text = "Time Left: " + Mathf.Round(timeLeft);
    }
}
