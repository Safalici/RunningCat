using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideBtnOnValueChange : MonoBehaviour
{
    public GameObject okbtn;
    // Start is called before the first frame update
    void Start()
    {
        okbtn.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
