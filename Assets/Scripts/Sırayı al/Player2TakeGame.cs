using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2TakeGame : MonoBehaviour
{
    public GameObject Player2;
    public GameObject Player1;
    public GameObject Border;
    public GameObject SırayıAlButonu;
    public GameObject Player_2SırayıAlButonu;
    public GameObject BorderPlayer_2;
    public int Player2PressedPlayAmount = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Player2PressedPlayAmount", 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void whenButtonisClicked()
    {
        Player2.GetComponent<Player_2>().enabled = true;
        Player1.GetComponent<Player>().enabled = false;
        

        Player2PressedPlayAmount++;
        PlayerPrefs.SetInt("Player2PressedPlayAmount", Player2PressedPlayAmount);

        if (BorderPlayer_2.activeInHierarchy == true && Player_2SırayıAlButonu.activeInHierarchy == true)
        {
            BorderPlayer_2.SetActive(false);
            Border.SetActive(true);
            Player_2SırayıAlButonu.SetActive(false);
            SırayıAlButonu.SetActive(true);

            
        }
    }
}
