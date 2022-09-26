using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadPlayer2InputName : MonoBehaviour
{
    private string Player2Name;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ReadStringPlayer2Name(string s)
    {
        Player2Name = s;
        PlayerPrefs.SetString("player2Name", Player2Name);
    }
}
