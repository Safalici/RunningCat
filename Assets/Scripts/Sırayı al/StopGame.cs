using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopGame : MonoBehaviour
{
    public GameObject Player2;
    public GameObject Player1;
    public GameObject Border_1;
    public GameObject Border_2;
    public GameObject Player_1S�ray�AlButonu;
    public GameObject Player_2S�ray�AlButonu;
    public GameObject finishBut;
    public GameObject saveBut;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void whenStopButtonClicked()
    {
        Player2.GetComponent<Player_2>().enabled = false;
        Player1.GetComponent<Player>().enabled = false;
        Border_1.SetActive(true);
        Player_1S�ray�AlButonu.SetActive(false);
        Player_2S�ray�AlButonu.SetActive(false);
        Border_2.SetActive(true);
        finishBut.SetActive(true);
        //saveBut.SetActive(false);
    }
}
