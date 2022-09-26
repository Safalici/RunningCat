using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadPlayerInputSchoolName : MonoBehaviour
{
    private string Player2SchoolName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ReadStringPlayer2SchoolName(string s)
    {
        Player2SchoolName = s;
        PlayerPrefs.SetString("player2SchoolName", Player2SchoolName);
    }
}
