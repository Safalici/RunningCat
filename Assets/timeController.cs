using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timeController : MonoBehaviour
{
    public float TimeLeft;
    public bool TimerOn = false;

    private DataEndGame data  = new DataEndGame();
    
    public Text TimerText;
    // Start is called before the first frame update
    void Start()
    {
        TimerOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (TimerOn)
        {
            if(TimeLeft >= 0)
            {
                TimeLeft -= Time.deltaTime;
                updateTimer(TimeLeft);
            }
            else
            {
                TimeLeft = 0;
                TimerOn = false;
                data.clickSaveButton();
                SceneManager.LoadScene("AfterGameEnds");

                /*DataEndGame endGameData = new DataEndGame();
                DataEndGameP2 endGameDataP2 = new DataEndGameP2();
                
                endGameData.clickSaveButton();*/

                //Application.Quit();
                //Debug.Log("Çýkýyor");
            }
        }
    }
    public void updateTimer(float currentTime)
    {
        currentTime += 1;
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        TimerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }

    public float GetTimeLeft()
    {
        return TimeLeft;
    }
}
