using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadPlayerInputClass : MonoBehaviour
{
    private string Player1ClassName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ReadStringInputClassName(string s)
    {
        Player1ClassName = s;
        PlayerPrefs.SetString("player1ClassName", Player1ClassName);
    }
}
