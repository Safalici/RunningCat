using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadPlayer2Class : MonoBehaviour
{
    private string Player2ClassName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ReadStringPlayer2ClassName(string s)
    {
        Player2ClassName = s;
        PlayerPrefs.SetString("player2ClassName", Player2ClassName);
    }
}
