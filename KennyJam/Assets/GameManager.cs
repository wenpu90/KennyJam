using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{   public static GameManager Instance;
    public Text timerText;
    public Text highscore;
    public Text secondscore;
    public Text thirdscore;
    public bool FreezeBool;
    float t = 0;

    //private float startTime;
    //private bool finished = false;

    public void GameFinished()
    {
        //float t = Time.time + startTime;
        //if (t < PlayerPrefs.GetFloat("HighScore", float.MaxValue))
        //{
        //    PlayerPrefs.SetFloat("HighScore", t);
        //    highscore.text = t.ToString();
        //    PlayerPrefs.Save();
        //}
    }

    void Start()
    {
        Instance = this;
        FreezeBool = true;
        //startTime = Time.time;
        //highscore.text = PlayerPrefs.GetFloat("HighScore", 0).ToString();
        //secondscore.text = PlayerPrefs.GetFloat("Secondscore", 0).ToString();
        //thirdscore.text = PlayerPrefs.GetFloat("Thirdscore", 0).ToString();
    }

    public void Timer_c(float i) {
        if (FreezeBool)
        {
            t += Time.deltaTime;
            i = t;
        
            string minutes = ((int)i / 60).ToString();
            string seconds = (i % 60).ToString("f0");
            if (i <= 59)
            {
                timerText.text = "TotalTime" + ": " + seconds + "s";
            }
            else
                timerText.text = "TotalTime" + minutes + "m" + ":" + seconds + "s";
        }
    }

    void Update()
    {
        Timer_c(0);

    }
}

