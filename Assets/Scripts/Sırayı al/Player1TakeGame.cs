using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player1TakeGame : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player2;
    public GameObject Player1;
    public GameObject Border;
    public GameObject SırayıAlButonu;
    public GameObject Player_2SırayıAlButonu;
    public GameObject BorderPlayer_2;
    public GameObject jumpButtonP1;
    public GameObject jumpButtonP2;
    

    public int Player1PressedPlayAmount = 0;
    

    



    void Start()
    {

        
        PlayerPrefs.SetInt("Player1PressedPlayAmountInt", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void whenButtonClickedP1()
    {
        
        Player2.GetComponent<Player_2>().enabled = false;
        Player1.GetComponent<Player>().enabled = true;

        
        

        Player1PressedPlayAmount++;
        PlayerPrefs.SetInt("Player1PressedPlayAmountInt", Player1PressedPlayAmount);
        if (Border.activeInHierarchy == true && SırayıAlButonu.activeInHierarchy==true)
        {
            Border.SetActive(false);
            SırayıAlButonu.SetActive(false);
            Player_2SırayıAlButonu.SetActive(true);
            BorderPlayer_2.SetActive(true);
   
        }
        
    }
}
